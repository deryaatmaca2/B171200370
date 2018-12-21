using Blog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.ViewModels
{
    public class Gallery
    {
        public List<Photos> Photos { get; set; }
    }
}