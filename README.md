# Data_Access
 Bu repo'da veri erişim katmanları hakkında bilgiler bulabilirsiniz.
 
 ## ORM(Object Relational Mapping)
  Nesne odaklı paradigmalar kullanarak bir veritabanından veri sorgulamamıza ve işlememize izin veren bir tekniktir.
  
 ### ORM Kullanmanın Avantajları :
  
  1- OOP standartlarına uygun olarak kod yazma imkanı.
  2- Minimum SQL bilgisi ile veritabanı işlemlerinin yapılması.
  3- Veritabanına bağımlılığı yoktur.
  4- Kod yazma süresini kısaltır.
  5- Kod okunabilirliğini arttırır.
  
  ### ORM Kullanmanın Dezavantajları :
  
  1-Manuel kodlamaya göre performansta daha yavaştır.
  2-İlk kez başlayanlar kullanmakta sıkıntı çekebilirler.
  3-Veritabanı nesneler üzerinden modellendiği için nesneler arasında bağlantı vardır.Bilinçsiz müdehaleler sonucunda bu bağlantılar kopabilir.
  
  ### Dillere Göre En Çok Kullanılan ORM Teknolojileri :
  C#: Entity Framework, Dapper, ECO, XPO, Norm
  Java: Hibernate, Ebean, Torque, JPA,MyBattis *Php: CakePHP, Codelgniter, RedBean, Doctrine,Propel, PdoMap
  Python: Django, South,Storm
  
  ## Entity Framework:
  Entity Framework, Microsoft tarafından desteklenen .NET uygulamaları için açık kaynaklı bir ORM çerçevesidir. Geliştiricilerin, bu verilerin depolandığı temel veritabanı tablolarına ve sütunlarına odaklanmadan etki alanına özgü sınıfların nesnelerini kullanarak verilerle çalışmasına olanak tanır. Entity Framework ile geliştiriciler, verilerle uğraşırken daha yüksek bir soyutlama düzeyinde çalışabilir ve geleneksel uygulamalara kıyasla daha az kodla veri odaklı uygulamalar oluşturabilir ve sürdürebilir.
  
  ## Yaklaşımlar
  ### 1.Database First:
  Bu yaklaşımda öncelik veritabanının oluşturulmasındadır ardından kodlamaya geçilir.
  
  ### 2.Code First
  Bu yaklaşımda design işlemlerinden çok kod yazma ön plandadır. Veritabanı işlemleri design işlemleri olarak değilde kod yazarak gerçekleştirilir. Geliştirici veritabanıyla ilgili tüm işlemleri kodlayarak oluşturur. Bu yaklaşımda hakimiyet tamamen sizdedir.
  
  ### 3.Model First
  Veritabanınız yoksa, doğrudan görsel stüdyodan bir model oluşturabilirsiniz. Burada yaptığımız değişiklikleri sql'ye tanıtmak için veritabanı oluştur'a tıklamamız gerekiyor.
