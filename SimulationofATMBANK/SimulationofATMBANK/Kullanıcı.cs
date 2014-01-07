using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationofATMBANK
{
    class Kullanıcı
    {
        private string Musteriİsim;
        private string MusteriSoyisim;
        private int HesapNumarası;
        private int EkHesap1;
        private int EkHesap2;
        private int Sifre;
        private double Bakiye;

        public Kullanıcı(string _Musteriİsim, string _MusteriSoyisim, int _HesapNumarası, int _Sifre, double _Bakiye,
            int _ekHesap1, int _ekHesap2)
        {
            Musteriİsim = _Musteriİsim;
            MusteriSoyisim = _MusteriSoyisim;
            HesapNumarası = _HesapNumarası;
            Sifre = _Sifre;
            Bakiye = _Bakiye;
            EkHesap1 = _ekHesap1;
            EkHesap2 = _ekHesap2;
        }

        public string GetMusteriİsim()
        {
            return Musteriİsim;
        }

        public string GetMusteriSoyisim()
        {
            return MusteriSoyisim;
        }

        public double GetBakiye()
        {
            return Bakiye;
        }

        public int GetSifre()
        {
            return Sifre;
        }

        public int GetHesapNumarası()
        {
            return HesapNumarası;
        }

        public void SetMusteriİsim(string _Musteriİsim)
        {
            Musteriİsim=_Musteriİsim;
        }

        public void SetMusteriSoyisim(string _MusteriSoyisim)
        {
            MusteriSoyisim=_MusteriSoyisim ;
        }

        public void SetBakiye(double _Bakiye)
        {
            Bakiye=_Bakiye;
        }

        public void SetSifre(int _Sifre)
        {
            Sifre=_Sifre;
        }

        public void SetHesapNumarası(int _HesapNumarası)
        {
            HesapNumarası=_HesapNumarası;
        }

    }
}
