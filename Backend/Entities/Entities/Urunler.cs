﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Urunler
    {
        public virtual int Id { get; set; }
        public virtual string Ad { get; set; }
        public virtual Kategori KategoriId { get; set; }
        public virtual DateTime Tarih { get; set; }
        public virtual decimal Fiyat { get; set; }
    }
}
