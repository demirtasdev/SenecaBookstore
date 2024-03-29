﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.ViewModels
{
    public class SectionViewModel
    {
        public string Title { get; set; }
        public string ImageClass { get; set; }

        private List<BookViewModel> _BookCards;
        public List<BookViewModel> BookCards
        {
            get
            {
                return _BookCards;
            }
            set
            {
                if (value.Count > 6)
                {
                    _BookCards = value.Take(6).ToList();
                }
                else
                {
                    _BookCards = value;
                }
            }
        }
    }
}