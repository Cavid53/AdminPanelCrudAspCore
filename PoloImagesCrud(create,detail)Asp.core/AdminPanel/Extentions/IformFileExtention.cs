using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Extentions
{
    public static class IformFileExtention
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains(@"image/");
        }

        public static bool CheckImageSize(this IFormFile file,int maxSize)
        {
            return file.Length / 1024 / 1024 < maxSize;
        }
        
        public  static async Task<string>  CopyImage(this IFormFile file,string root,string folder)
        {
            string path = Path.Combine(root, "img");

            string filename = Path.Combine("folder", Guid.NewGuid().ToString() + file.FileName);
            string resultPath = Path.Combine(path, filename);

            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            string replace_filename = filename.Replace(@"\", "/");
            return replace_filename;
        }

    }
}
