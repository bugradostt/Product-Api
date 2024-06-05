using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Dtos.Response
{
    public class ErrorDto
    {
        public List<string> Errors { get; private set; } = new List<string>(); 
        public bool IsShow { get; private set; } // Kullanıcıya verilmesi istenen bir hata ise True yapılmalı
        public ErrorDto()
        {
            Errors = new List<string>(); //Errors = new List<string>(); C# 12 ++
            IsShow = false;
        }
        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            IsShow = isShow;
        }
        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }

    }
}
