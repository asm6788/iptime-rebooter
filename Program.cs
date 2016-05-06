using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace iptime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("재부팅시킬 공유기의 IP를 알려주세요");
            string host = Console.ReadLine();
            Console.WriteLine("쿠키도");
            Reboot(host, Console.ReadLine());
        }

        static void Reboot(string host,string coookie)
        {
            CookieContainer gaCookies = new CookieContainer();
            gaCookies.Add(new Cookie("efm_session_id", coookie) { Domain = host });
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://"+host+ "/sess-bin/timepro.cgi?tmenu=background&smenu=reboot&commit=reboot");
            request.CookieContainer = gaCookies;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // 응답 Stream 읽기
            Stream stReadData = response.GetResponseStream();
            StreamReader srReadData = new StreamReader(stReadData, Encoding.Default);

            // 응답 Stream -> 응답 String 변환
            string strResult = srReadData.ReadToEnd();

            Console.WriteLine(strResult);
            Console.ReadLine();
        }
    }
}
