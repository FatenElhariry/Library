using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Library.BLL
{
    public class Helper
    {
        public static byte[] ConvertToByte(HttpPostedFileBase file)
        {
            byte[] imageByte = null;
            BinaryReader rdr = new BinaryReader(file.InputStream);
            imageByte = rdr.ReadBytes((int)file.ContentLength);
            return imageByte;
        }
    }
}