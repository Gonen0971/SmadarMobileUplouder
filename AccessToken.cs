using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows;

namespace SmadarMobileUplouder
{
    public class AccessToken : Form1, IPostInterface
    {
        // Variabels
       private string _Token, _CompanyUrl = "";

        IDictionary<string, string> TokenKeys = new Dictionary<string, string>();
        const string _PostUrl = "https://smadar.app/api/user/login";

        // Properties from Interface

        public string Token
        {
            get { return _Token; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this._Token = value;
                }
                else
                    throw new ArgumentNullException("Token is empty!");
            }
        }
        public bool HasAccessToken
        {
            get
            {
                if (!string.IsNullOrEmpty(Token))
                    return true;
                else
                    return false;

            }
        }

        public string companyUrl
        {
            get { return _CompanyUrl; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this._CompanyUrl = value;
                }
                else
                    throw new ArgumentNullException("CompanyUrl is empty!");
            }
        }


        // ------ Constractor  --
        
        public AccessToken()
        {

        }
        // ----- Methods   ----
        public void GetAccessToken(string domain_name, string company_code, IDictionary<string, string> ListFiles64, string path_type, string path, bool enable_auth, string auth_user, string auth_password) 
        {
            string ParamName = "organization_code";
            string ParamValue = "";
           

            if (!String.IsNullOrEmpty(company_code))
            {
                ParamName = "organization_code";
                ParamValue = company_code;

            }
            else if (!String.IsNullOrEmpty(domain_name))
            {
                ParamName = "Domain_name";
                ParamValue = domain_name;
            }

            else if (String.IsNullOrEmpty(base.company_code) && String.IsNullOrEmpty(domain_name))
            {
                Trace.TraceError(DateTime.Now + " " + "GetAccessToken:  domain_name & Company_code are missing");
                LogMessage(DateTime.Now + " " + "GetAccessToken:  domain_name & Company_code are missing");
                throw new ArgumentNullException("GetAccessToken:  domain_name & Company_code are missing");
            }

            // Get UserName & Password for Authentication
            GetAuthDetails(enable_auth, auth_user, auth_password);
                       
            TokenKeys.Add("user_type", "Cli");
            TokenKeys.Add(ParamName, ParamValue);

            // Run Post Request for getting access token from the server
            Trace.TraceInformation(DateTime.Now + " " + "GetAccessToken(Before PostRequest): URL: " + _PostUrl + " ," + ParamName + ": " + ParamValue);
            PostRequest(TokenKeys, ListFiles64, path_type, path);

        }

        private void GetAuthDetails(bool enable_auth, string auth_user, string auth_password)
        {
            if (!enable_auth || string.IsNullOrEmpty(auth_user) || string.IsNullOrEmpty(auth_password))
            {
                auth_user = "winsert";
                auth_password = "Aa123456";
            }
            
            TokenKeys.Add("username", auth_user);
            TokenKeys.Add("password", auth_password);
        }
        public async void PostRequest(IDictionary<string, string> TokenKeys, IDictionary<string, string> ListFiles64, string path_type, string path)
        {
          try
            {

                //HttpContent content = new FormUrlEncodedContent(keys);
                var content = JsonConvert.SerializeObject(TokenKeys);
                var data = new StringContent(content, Encoding.UTF8, "application/json");

                using (HttpClient Client = new HttpClient())
                {
                    Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

                    var response = await Client.PostAsync(_PostUrl, data).ConfigureAwait(true);
                    string responseString = "";
                    using (HttpContent Rescontent = response.Content)
                    {
                        // Make sure the post succeeded, and write out the response.
                        if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                        {
                            //    System.Threading.Thread.Sleep(1000);
                            responseString = response.Content.ReadAsStringAsync().Result;
                            Trace.TraceInformation(DateTime.Now + " " + "PostRequest -Response: " + responseString);

                            if (responseString.IndexOf("token", 0, responseString.Length - 1) != -1)
                            {
                                dynamic d = JsonConvert.DeserializeObject(responseString);
                                Token = d["token"];
                                companyUrl = d["url"];
                                Trace.TraceInformation(DateTime.Now + " " + "PostRequest -Got Token: " + Token);
                                Trace.TraceInformation(DateTime.Now + " " + "PostRequest -Got URL: " + companyUrl);

                                // Run HTTPRequest
                                HTTPRequest MyRequest = new HTTPRequest();
                                MyRequest.PrepareDocumentRequest(companyUrl, Token, ListFiles64, path_type, path);
                            }
                            else
                            {
                                Trace.TraceError(DateTime.Now + " " + "PostRequest: " + responseString);
                               LogMessage( "PostRequest: " + responseString);

                            }
                        }


                    }
                }
            }


            catch (Exception ex)
            {

                Trace.TraceError(DateTime.Now + " " + "PostRequest Exception:" + ex.ToString());
                LogMessage(DateTime.Now + " " + "PostRequest Exception:" + ex.ToString());
            }


        }
    }
}
