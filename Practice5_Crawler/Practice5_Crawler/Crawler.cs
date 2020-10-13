using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Concurrent;

namespace Practice5_Crawler
{
    //Url类
    class Url
    {
        public string url { get; set; }//url地址
        public bool isProcessing { get; set; }//判断该url是否正在被处理
        public string html { get; set; }//文本内容
    }
    class Crawler
    {
        public event Action<Crawler, Url> PageDownloaded;
        public ConcurrentBag<Url> urlBag = new ConcurrentBag<Url>();//线程安全的集合
        public int count = 0;
        public string startUrl = "";//初始URL
        public string matchUrl = "";//处理后用于匹配的URL

        public void Crawl()//爬取函数
        {
            Url url = new Url()
            {
                url = startUrl,
                isProcessing = false,
                html = ""
            };
            urlBag.Add(url);

            string str = @"(www\.){0,1}.*?\..*?/";//匹配出起始网站
            Regex reg = new Regex(str);
            Match mat = reg.Match(startUrl);
            matchUrl = mat.Value;

            while (true)
            {
                Url current = null;
                foreach(var s in urlBag)
                {
                    if (s == null || s.isProcessing == true) continue;
                    current = s;
                    if (count > 20) break;
                    current.isProcessing = true;
                    var th = new Thread(() => Process(current));//开始处理url
                    th.Start();
                    count++;
                }
            }
        }

        public bool UrlExists(string url)//避免重复爬取
        {
            foreach(Url s in urlBag)
            {
                if (s.url == url) return true;
            }
            return false;
        }

        public void Process(Url url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url.url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);//读取文本内容
                url.html = html;
                PageDownloaded(this, url);
                Parse(html, url.url);
            }
            catch (Exception) { }
        }

        private void Parse(string html,string oldUrl)//在文本中寻找可爬取的URL
        {
            string str = @"(href|HREF)[ ]*=[ ]*[""'](http|https)[^""'#>]+..html.*?[""']";
            MatchCollection collection = new Regex(str).Matches(html);
            foreach(Match m in collection)
            {
                var url = m.Value.Substring(m.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0) continue;
                Uri baseUri = new Uri(oldUrl);//将相对地址转换成绝对地址
                Uri absoluteUri = new Uri(baseUri, url);
                if (url.Contains(matchUrl))
                {
                    if (!UrlExists(url))
                    {
                        urlBag.Add(new Url()
                        {
                            url = url,
                            isProcessing = false,
                            html = ""
                        });
                    }
                }
            }
        }
    }
}
