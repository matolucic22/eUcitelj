﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUcitelj.MVC_WebApi.ViewModels
{
    public class PredmetiViewModel
    {
        public string Ime_predmeta { get; set; }

        public Guid KorisnikId { get; set; }

        public Guid PredmetiId { get; set; }

        public virtual ICollection<PredmetiViewModel> Ocjene { get; set; }//1 predmet moze imati vise ocijena

        public virtual ICollection<KvizViewModel> Kviz { get; set; }//1 predmet moze imati vise ocijena
        public virtual KorisnikViewModel Korisnik { get; set; }//poziva jednog korisnika di je npr id=1; - 1 predmet ima vise korisnika. Zato što svaki model ima 1 make m
    }
}