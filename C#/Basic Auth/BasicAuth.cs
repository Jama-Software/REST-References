using System;
using System.IO;
using System.Net;
//feat1 01
//feat1 02
//feat3 01
//feat3 02
//feat2 01
//feat2 02
//feat1 03
//feat4 01

public class BasicAuth
{
    static public void Main()
    {
        string baseUrl = "{base url}.jamacloud.com/rest/latest/";

        // Username and password should be stored according
        // to your organization's security policies
        string username = "API_User";
        string password = "********";

        string resource = "projects";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + resource);
        request.Method = WebRequestMethods.Http.Get;

        string credentials = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(username + ":" + password));
        request.Headers["Authorization"] = "Basic " + credentials;

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        Stream stream = response.GetResponseStream();
        StreamReader streamReader = new StreamReader(stream);
        string s = streamReader.ReadToEnd();

        Console.WriteLine(s);
    }
}
