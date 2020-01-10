using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmadarMobileUplouder
{
    //------------   HTTPRequest Class    ------------------
        public  class HTTPRequest :AccessToken
        {
           // Variables
          
          // Properites from Interface


        public void ClearAccessToken()
            {
                Token = null;
            }
        
        // ----------------------------------            

        //  --  Constartor  --
        public HTTPRequest()
        {
            ListFiles64 = base.ListFiles64.ToDictionary(entry => entry.Key,
                                               entry => entry.Value);
            //path_type = base.path_type;
            //path = base.path;
        }

            /// <summary>
            /// Base64 convert - converts PDF to Base64 string text
            /// </summary>
            /// <param name="pdfFilePath"></param>
            /// <returns></returns>

            public static string Base64Convert(string pdfFilePath)
            {
                byte[] pdfBytes = System.IO.File.ReadAllBytes(pdfFilePath);

                return (Convert.ToBase64String(pdfBytes));
            }

            public void PrepareDocumentRequest(string companyUrl, string Token, IDictionary<string, string> ListFiles64, string path_type, string path)
            {

                companyUrl += "document/create";
                Trace.TraceInformation(DateTime.Now + " " + "PrepareDocumentRequest -Got URL: " + companyUrl);

                if (!string.IsNullOrEmpty(Token) && ListFiles64.Count >0)
                {
                    // Loop on all files to upload //
                    foreach (string file_name in ListFiles64.Keys)
                    {

                        Trace.TraceInformation(DateTime.Now + " " + "PrepareDocumentRequest -Loop on file: " + file_name);
                        IDictionary<string, string> post = new Dictionary<string, string>();
                        if (!string.IsNullOrEmpty(Token))
                        {
                            //post.Add("token", Token);
                            post.Add("file_name", file_name);
                            post.Add("path_type", path_type);
                            post.Add("path", path);
                            post.Add("file_data", ListFiles64[file_name]);

                            CreateDocumentRequest(companyUrl, post, Token);
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                MessageBox.Show("File(s) uploaded sucessfully!");
               
                }

                else
                {
                    MessageBox.Show("Can not post document to server - missing access token");
                    Trace.TraceError(DateTime.Now + "PrepareDocumentRequest- Can not post document to server - missing access token ");
                }

            }


            /// <summary>
            /// Post FIle to server
            /// </summary>

            public async void CreateDocumentRequest(string PostUrl, IDictionary<string, string> keys, string Token)
            {
                Trace.TraceInformation(DateTime.Now + " " + "CreateDocumentRequest- PostUrl:" + PostUrl);
                try
                {
                    using (HttpClient Client = new HttpClient())
                    {

                    if (!string.IsNullOrEmpty(Token))
                    {
                        Client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", Token);
                        string stringPayload = JsonConvert.SerializeObject(keys);
                        //Trace.TraceInformation(DateTime.Now + " " + "CreateDocumentRequest- PayLoad:" + stringPayload);
                        // Trace.TraceInformation(DateTime.Now + " " + "CreateDocumentRequest- AccessToken:" + HTTPRequest.Token);

                        var mycontent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

                        var response = await Client.PostAsync(PostUrl, mycontent);

                        string responseString = "";
                        using (HttpContent Rescontent = response.Content)
                        {
                            // Make sure the post succeeded, and write out the response.
                            if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                            {

                                Task<string> result = Rescontent.ReadAsStringAsync();
                                responseString = result.Result;
                                Trace.TraceInformation(DateTime.Now + " " + "CreateDocumentRequest- Response:" + responseString);

                                if (responseString.IndexOf("token", 0, responseString.Length - 1) != -1)
                                {
                                    dynamic d = JsonConvert.DeserializeObject(responseString);
                                }
                                else
                                {
                                    Trace.TraceError(DateTime.Now + " " + "HTTP Request -Exception: " + responseString);
                                    base.LogMessage("HTTP Request -Exception: " + mycontent);
                                }
                                Trace.TraceInformation(DateTime.Now + "CreateDocumentRequest - Success to upload file " + keys["file_name"] + " to server");
                                base.LogMessage("File(s) uploaded to server successfully  " + keys["file_name"]);


                            }
                        }
                    }
                    else
                    {
                        Trace.TraceError(DateTime.Now + " " + "CreateDocumentRequest  - AccessToken is empty!");
                        base.LogMessage("AccessToken is empty");
                    }
                }
        }
        catch (Exception ex)
        {
             MessageBox.Show("PostRequest Error:" + ex.ToString());
             Trace.TraceError(DateTime.Now + " " + "CreateDocumentRequest Exception: " + ex.ToString());
        }


    }
 }

  //--------------- Response Class   ------------------
        public class Response
    {
        bool IsSuccess = false;
        string Message;
        object ResponseData;

        public Response(bool status, string message, object data)
        {
            IsSuccess = status;
            Message = message;
            ResponseData = data;
        }
    }

    }
