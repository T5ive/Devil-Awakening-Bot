namespace Devil_Awakening_Bot.Auth;

internal static class Connection
{
    internal static string GetLimit(string user, string date)
    {
        try
        {
            var bytes = Encoding.UTF8.GetBytes(string.Concat(new[]
            {
                "username=",
                user,
                "&today=",
                date
            }));
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/login/get.php");
            httpWebRequest.AllowAutoRedirect = true;
            httpWebRequest.ContentLength = bytes.Length;
            httpWebRequest.KeepAlive = true;
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Method = "POST";
            httpWebRequest.AllowWriteStreamBuffering = true;
            using var requestStream = httpWebRequest.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);

            using var responseStream = httpWebRequest.GetResponse().GetResponseStream();
            var streamReader = new StreamReader(responseStream);
            var res = streamReader.ReadToEnd();
            var array = Regex.Split(EncryptionPHP.DecryptString(res, "lnwza007"), "<br>");
            if (array[2].Equals("Success") || array[1].Length > 6)
            {
                return array[1];
            }
        }
        catch
        {
            Msg.Error("Username has wrong");
            return "Error";
        }

        return "Error";
    }
    internal static string SetLimit(string user, string limit)
    {
        try
        {
            var bytes = Encoding.UTF8.GetBytes(string.Concat(new[]
            {
                "username=",
                user,
                "&limit=",
                limit
            }));
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/login/set.php");
            httpWebRequest.AllowAutoRedirect = true;
            httpWebRequest.ContentLength = bytes.Length;
            httpWebRequest.KeepAlive = true;
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Method = "POST";
            httpWebRequest.AllowWriteStreamBuffering = true;
            using var requestStream = httpWebRequest.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);

            using var responseStream = httpWebRequest.GetResponse().GetResponseStream();
            var streamReader = new StreamReader(responseStream);
            var res = streamReader.ReadToEnd();
            var array = Regex.Split(EncryptionPHP.DecryptString(res, "lnwza007"), "<br>");
            if (array[2].Equals("Success") || array[1].Length > 6)
            {
                return array[1];
            }
        }
        catch
        {
            Msg.Error("Username has wrong");
            return "Error";
        }

        return "Error";
    }
}