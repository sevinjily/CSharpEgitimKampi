using System.IO;

namespace WebUI.Helpers
{
    /// <summary>
    /// Salam bu bir file yukleme clasidir
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// bu bir file yukleme metodudur async
        /// </summary>
        /// <param name="file">IformFile tipinden nese</param>
        /// <param name="WebRootPath">wwwroot</param>
        /// <param name="folderName">Folder adi</param>
        /// <returns>Bu sene seklin cigirini qaytaracaq</returns>
        public static async Task<string> SaveFileAsync(this IFormFile file,string WebRootPath,string folderName)
        {
            if(!Directory.Exists(WebRootPath+folderName)) 
            {
            Directory.CreateDirectory(WebRootPath+folderName);
            }
            //var path="uploads/"+Guid.NewGuid()+file.FileName;
            string path = Path.Combine(folderName, Guid.NewGuid() + file.FileName);
            using FileStream fileStream = new(WebRootPath + path, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return path;
        }
    }
}
