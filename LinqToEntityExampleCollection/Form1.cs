using LinqToEntityExampleCollection.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToEntityExampleCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void btnTolist_Click(object sender, EventArgs e)
        {
            /*ToList()=> Metodu veritabında bulunan tablodaki  tüm üürnlerin tablonun yansımasında ki nesnesinin tipinde bir generic list hazırlaması için kullanılır.*/
            dataGridView1.DataSource = db.Categories.ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            /*Where()=> Vaeirtabanımızda bulunan tablolarda filtrelene işlemi yapmak için kullanılır.*/
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20).ToList();
            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20 && x.UnitPrice < 50).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            /*T-SQL'de bulunan Order BY deyimi ile aynı görevi üstlenmektedir. Sorgu sonucuna göre gelen generic list ieçrisinde sıralama işlemleri yapmaktadır. */
            dataGridView1.DataSource = db.Products.OrderBy(p => p.ProductName).ToList();
            //Order BY Descending
            dataGridView1.DataSource = db.Products.OrderByDescending(p => p.UnitPrice).ToList();
        }

        private void btnFirstMethodu_Click(object sender, EventArgs e)
        {
            /*First()=> İBİr koleksiyon içerisinde ki ilk elemanı seçmek için kullanılmaktadır.*/

            Category category = db.Categories.First();
            if (category == null)
            {
                MessageBox.Show("BÖyle Bir Kategori Bulunamadı");
            }
            else
            {
                MessageBox.Show(category.CategoryName);
            }
            Category cat = db.Categories.First(x => x.CategoryID > 6);
            if (cat == null)
            {
                MessageBox.Show("Böyle bir katgegori bulunmadı!");
            }
            else
            {
                MessageBox.Show(cat.CategoryName);
            }
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            /*FirstOrDefault()=> First ile aynı kullanım amacına sahiptir. Farklı oalrak FirstOrDefault içerisinde sağlanmayan bir şart verildiğinde Fİrst metodunda 
            ki gibi hata vermeyecektir. Sadece veritabanında eşleşen bir kayıt bulunmadığından Category nesnesini null oalrak bırakacaktır*/
            Category category = db.Categories.FirstOrDefault(x => x.CategoryID > 7);
            if (category == null)
            {
                MessageBox.Show("Böyle bir katgegori bulunmadı!");
            }
            else
            {
                MessageBox.Show(category.CategoryName);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            /*Find()=> Microsft SQL Server üzerinde veritabanı işlmelerini incelerken Identity Key(ID) değerinden söz etmiştik HATIRLARSANIZ.....
            .Uniq olduğundan tek bir kayıt'a erişmek için ID kolunu kullanılmaktadır. Entity Framework kütpühanesini kullanarak veritabanında bulunna tablolarımzıda 
            tek bir kolona erişmek için kullanılıyoruz*/
            Category GelenKategori = db.Categories.Find(1);
            MessageBox.Show(GelenKategori.CategoryName);

            /*Kategori ve Tedarikçi ID'si 1 olan ürünleri isme gçre tersten sıralayın*/

            dataGridView1.DataSource = db.Products.Where(x => x.CategoryID == 1 && x.SupplierID == 1).OrderByDescending(x => x.ProductName).ToList();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            /*Take()=> T-SQL sorgularında kullandığımız Top komutunun görevini üstlenmektedir. Bİr sorgu sonucunda dönen listeden en üstteki belirlediğimiz sayıda satırı 
            ekranda göstermemizi sağlar*/

            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).Take(5).ToList();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            /*Skip()=> Dönen sorgu sonucundan en üsetteki x kadar satırı atlayarak o satırdan sonraki belirlediğiniz sayıda satıre ekranda göstermemizi sağlar.*/

            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).Skip(5).Take(5).ToList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            /*Contains()=> T-SQL örneklerinde Like komutu mantığınd açalışır.*/

            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.Contains("a")).ToList();
        }

        private void btnStarAndEndWith_Click(object sender, EventArgs e)
        {
            /*StartWith() - EndWith()=> Like sorgusundaki başlayan ce biten karakterlere göre aramalr yapamnızı sağlayan mettolardır.
               Belirlenenkolunun verilen ifade ile başlayıp başlamadığını, bitip bitmediğini kontorl eder ve sonuç döndürür.*/

            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.StartsWith("c")).ToList();

            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.EndsWith("a")).ToList();
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            /*Any()=> İki farklı kulanıma sahip olan Any metodu ilk kullanımı olan bir tabloda kayıt olup olmadığını kontrol edebilir. 
            İkinci kullanımı ise tabloda verilen şartlara uygun kayıt olup olmadığını kontrol etmektektedir. Any Metodu geriye sonuç 
            olarak boolean veri tipinde döniş yapmkatadır.*/

            /*Kategoriler tablosunda Becearges isimli bir kategori var mı yok mu*/

            bool sonuc = db.Categories.Any(x => x.CategoryName == "Becerages");

            MessageBox.Show(sonuc.ToString());

            /*Kategoriler tablosunda adi Be ile başalyan bir kategori bvar mı yok mu*/

            bool result = db.Categories.Any(x => x.CategoryName.StartsWith("Be"));

            MessageBox.Show(result.ToString());
        }

        /*********************/
        /*AGGREGATE FUNCTION*/
        /*******************/

        //T-SQL soruglarınnın ve raporlarının vazgeçilmezi olan bütünleşik fonksiyonları Entity Framework kütphanesi ilede kulanabilrisiniz.

        private void btnCount_Click(object sender, EventArgs e)
        {
            /*Count()=> T-SQL'den de hatırlayacağınız gibi COunt() metodu sorgu sonucunda dönen result'un satırlarını saymakyadır. Count metodu geriye int değer 
            tipinde dönüş yapar.*/

            int UrunSayisi = db.Products.Count();
            MessageBox.Show(UrunSayisi.ToString());
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            /*SUM()=> T-SQL'de kullanılan SUm metodu ile aynı görevi üstlenir. Dönen result içeirsnde belirlediğiniz kolnların değerlerinin toplanmasını sağlar.*/

            /*Tüm ürünler dahil olamk üzere dahil olamk üzere stoğumda kaç adet ürün var(Not: Her ürünüün stok değerlerini toplamak istiyoruz)*/

            decimal? fiyat = db.Products.Sum(x => x.UnitsInStock);

            MessageBox.Show(fiyat.ToString());
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            /*Min()-Max()=> Bir kolon içerisndeki maxsimum ve minimum değerleri bulmak için kullanacağımız metotlardır.*/

            //En pahalı ürün siyatı nedir?
            decimal? EnYuksekFiyat = db.Products.Max(x => x.UnitPrice);
            MessageBox.Show(EnYuksekFiyat.ToString());
            //En ucuz ürün fiyatı?
            decimal? EnDusukFiyat = db.Products.Min(x => x.UnitPrice);
            MessageBox.Show(EnDusukFiyat.ToString());
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            /*T-SQL'deki gibi tekrar eden değerleri egale etmek için kullanır*/

            //Hangi ülkelerle iş yapıyoruz? Ülke listesini çıkartın
            List<string> liste = db.Orders.Select(x => x.ShipCountry).Distinct().ToList();

            foreach (string item in liste)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            /*Select()=>Select metodu sorgularınızı çekerken istediğiniz kolonları almanıza veya kolon isimleriniz kullanıcılara göstermek için değiştirmenize olanak sağlar.*/

            //Müşterilerin müşteri adı,yetkilisi, telefonu ve adresini farklı kolon ismleriyle getiren souruyu yazınız

            dataGridView1.DataSource = db.Customers.Select(x => new
            {
                MusteriSİrketi = x.CompanyName,
                Yetkili = x.ContactName,
                Telefon = x.Phone,
                Adres = x.Address
            }).ToList();
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            /*GroupBy()=> SOrgularımızdan dönen sonuçalrı belli kriterlere göre gruplamanızı sağlar.*/

            //Hangi kategoride kaç adet ürünüm var

            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName).Select(y => new
            {
                KategoriAdi = y.Key,
                ToplamStok = y.Sum(x => x.UnitsInStock)
            }).ToList();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            /*T-SQL sorgualrı yazarken select sorgularımızda birden fazla tablodan veir çekmemiz gereken duurmlarla karşılaşabiliyorduk. 
            Bu işlemler için uzun ve karışık join sorguları yazmamız gerekmektedir. Entity Framework kütüphanesi kullanırken bir verirnin 
            başka bir tablo ile olan bağlantısı üzerinden (join yaaprak) veri çekmek oldukça kolay bir işlemdir.*/

            //Ürünlerin ürün adını, fiyatını, stok mikatrını, kategori adını ve tedarikçi adını getiren sorguyu yazınız

            dataGridView1.DataSource = db.Products.Select(x => new
            {
                UrunAdi = x.ProductName,
                Fiyat = x.UnitPrice,
                Stok = x.UnitsInStock,
                Kategori = x.Category.CategoryID,
                Tedarikci = x.Supplier.CompanyName
            }).ToList();
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            /*Function Kullanımı: Entity Framework kütüphanesi kullanırken T-SQL'de bulunna belli başlı fonksiyonları kullanmanız gereketiği durumlarda bu 
            fonksiyonları kolayca kullanaiblirsiniz*/

            //Çalışanların yaşlarını hesaplayın

            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                Adi = x.FirstName,
                Soyadi = x.LastName,
                DogumTarihi = x.BirthDate,
                Yasi = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)
            }).ToList();
        }
    }
}

