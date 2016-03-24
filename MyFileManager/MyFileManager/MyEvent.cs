using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace MyFileManager
{
    class MyEvent
    {
        public MyEvent()
        {

        }
        public MyEvent(FileInfo file)
        {
            FileName = file.Name;
            SourceFolder = file.Directory.ToString();
            SizeB = file.Length;
            TargetFile = file;
        }

        /// <summary>
        /// Ключевое поле
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Имя файла
        /// </summary>
        [MaxLength(1024)]
        public string FileName { get; set; }
        /// <summary>
        /// Исходные каталог
        /// </summary>
        [MaxLength(4096)]
        public string SourceFolder { get; set; }
        /// <summary>
        /// Целевой каталог
        /// </summary>
        [MaxLength(4096)]
        public string TargetFolder { get; set; }
        /// <summary>
        /// Размер файла в байтах
        /// </summary>
        public long SizeB { get; set; }
        /// <summary>
        /// Ошибки операции
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// Результат операции в процентах 0...100%
        /// </summary>
        public int Result { get; set; }
        /// <summary>
        /// Дата и время начала операции
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Длительность операции
        /// </summary>
        public int ElapsedTime { get; set; }
        /// <summary>
        /// файл
        /// </summary>
        [NotMapped]
        public FileInfo TargetFile { get; set; }


    }
}
