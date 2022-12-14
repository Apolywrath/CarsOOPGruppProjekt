using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CarsOOPGruppProjekt
{
    internal class CarLogos
    {
        static public WebClient client = new WebClient();
        static public string audiLink = "https://www.carlogos.org/car-logos/audi-logo.png";
        static public Image audiLogo = Image.FromStream(new MemoryStream(
            client.DownloadData(audiLink)));
        static public string fordLink = "https://www.carlogos.org/car-logos/ford-logo.png";
        static public Image fordLogo = Image.FromStream(new MemoryStream(
            client.DownloadData(fordLink)));
    }
}
