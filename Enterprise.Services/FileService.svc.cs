using Enterprise.Logic.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Hosting;

namespace Enterprise.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FileService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FileService.svc or FileService.svc.cs at the Solution Explorer and start debugging.
    public class FileService : IFileService
    {
        public void DoWork()
        {
        }

        public string UploadFile(ImageData imageData)
        {
            var imagePath = HostingEnvironment.ApplicationPhysicalPath + "Images";
            var exists = System.IO.Directory.Exists(imagePath);

            if (!exists)
                System.IO.Directory.CreateDirectory(imagePath);
            var FilePath = Path.Combine(imagePath, imageData.FileName);
            using (var writer = new FileStream(FilePath, FileMode.Create))
            {
                writer.Write(imageData.FileData, 0, imageData.FileData.Length);
            }
            return "/Images/" + imageData.FileName;
        }


        public void UploadImage(RemoteFileInfo request)
        {
            FileStream targetStream = null;
            var sourceStream = request.FileByteStream;

            var uploadFolder = @"C:\upload\";

            var filePath = Path.Combine(uploadFolder, request.FileName);

            using (targetStream = new FileStream(filePath, FileMode.Create,
                                  FileAccess.Write, FileShare.None))
            {
                //read from the input stream in 65000 byte chunks

                const int bufferLen = 65000;
                var buffer = new byte[bufferLen];
                var count = 0;
                while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
                {
                    // save to output stream
                    targetStream.Write(buffer, 0, count);
                }
                targetStream.Close();
                sourceStream.Close();
            }
        }
    }
}
