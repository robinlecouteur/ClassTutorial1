﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gallery3WinForm
{
    public static class ServiceClient
    {
        internal async static Task<List<string>> GetArtistNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync("http://localhost:60064/api/gallery/GetArtistNames/"));
        }

        internal async static Task<clsArtist> GetArtistAsync(string prArtistName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsArtist>
                    (await lcHttpClient.GetStringAsync
                    ("http://localhost:60064/api/gallery/GetArtist?Name=" + prArtistName));
        }
    }
}
