﻿using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string NewPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;
            string path = Environment.CurrentDirectory + @"\wwwroot\Images";

            var creatingUniqueFilename = Guid.NewGuid().ToString()
                + "_" + DateTime.Now.Month
                + "_" + DateTime.Now.Day
                + "_" + DateTime.Now.Year + fileExtension;

            

            string result = $@"{path}\{creatingUniqueFilename}";

            return result;
        }

        public static string AddAsync(IFormFile file)
        {
            {
                var sourcepath = Path.GetTempFileName();
                if (file.Length > 0)
                {
                    using (var stream = new FileStream(sourcepath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
                var result = NewPath(file);
                File.Move(sourcepath, result);
                return result;
            }
        }

        public static string UpdateAsync(string sourcePath, IFormFile file)
        {
            var result = NewPath(file);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }

        public static IResult DeleteAsync(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }

        

    }
}
