﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model.LibraryEntities;

namespace Library.Query
{
    public class FindBookQuery
    {
        public Book Book { get; set; }

        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Story> Stories { get; set; }
        public IEnumerable<Publisher> Publishers { get; set; }


        public int? BeginYear { get; set; }
        public int? EndYear { get; set; }
    }
}
