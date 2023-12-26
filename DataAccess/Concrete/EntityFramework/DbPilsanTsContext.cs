using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concrete;

public partial class DbPilsanTsContext : DbContext
{
    public DbPilsanTsContext()
    {
    }

    public DbPilsanTsContext(DbContextOptions<DbPilsanTsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnketYeni> AnketYenis { get; set; }

    public virtual DbSet<CariOdeme> CariOdemes { get; set; }

    public virtual DbSet<CatMark> CatMarks { get; set; }

    public virtual DbSet<CatProd> CatProds { get; set; }

    public virtual DbSet<DbAdminModule> DbAdminModules { get; set; }

    public virtual DbSet<DbAnket> DbAnkets { get; set; }

    public virtual DbSet<DbAnketCategory> DbAnketCategories { get; set; }

    public virtual DbSet<DbAnketHazirCevap> DbAnketHazirCevaps { get; set; }

    public virtual DbSet<DbAnketcvp> DbAnketcvps { get; set; }

    public virtual DbSet<DbAnketcvpAlt> DbAnketcvpAlts { get; set; }

    public virtual DbSet<DbAssessment> DbAssessments { get; set; }

    public virtual DbSet<DbBank> DbBanks { get; set; }

    public virtual DbSet<DbBanner> DbBanners { get; set; }

    public virtual DbSet<DbBasvurular> DbBasvurulars { get; set; }

    public virtual DbSet<DbBayiler> DbBayilers { get; set; }

    public virtual DbSet<DbBlog> DbBlogs { get; set; }

    public virtual DbSet<DbCariTest> DbCariTests { get; set; }

    public virtual DbSet<DbCentry> DbCentries { get; set; }

    public virtual DbSet<DbContact> DbContacts { get; set; }

    public virtual DbSet<DbDistrict> DbDistricts { get; set; }

    public virtual DbSet<DbDokuman> DbDokumen { get; set; }

    public virtual DbSet<DbEvent> DbEvents { get; set; }

    public virtual DbSet<DbFaturaDonemleri> DbFaturaDonemleris { get; set; }

    public virtual DbSet<DbFriend> DbFriends { get; set; }

    public virtual DbSet<DbGallery> DbGalleries { get; set; }

    public virtual DbSet<DbGalleryCategory> DbGalleryCategories { get; set; }

    public virtual DbSet<DbIscilikTipi> DbIscilikTipis { get; set; }

    public virtual DbSet<DbKullaniciTanimlari> DbKullaniciTanimlaris { get; set; }

    public virtual DbSet<DbKullanilanMalzemeler> DbKullanilanMalzemelers { get; set; }

    public virtual DbSet<DbKullanilanParcalar> DbKullanilanParcalars { get; set; }

    public virtual DbSet<DbLanguage> DbLanguages { get; set; }

    public virtual DbSet<DbLisan> DbLisans { get; set; }

    public virtual DbSet<DbLogger> DbLoggers { get; set; }

    public virtual DbSet<DbLow> DbLows { get; set; }

    public virtual DbSet<DbLowcat> DbLowcats { get; set; }

    public virtual DbSet<DbMail> DbMails { get; set; }

    public virtual DbSet<DbMailList> DbMailLists { get; set; }

    public virtual DbSet<DbMark> DbMarks { get; set; }

    public virtual DbSet<DbMenu> DbMenus { get; set; }

    public virtual DbSet<DbMenuList> DbMenuLists { get; set; }

    public virtual DbSet<DbMenuListNew> DbMenuListNews { get; set; }

    public virtual DbSet<DbMessage> DbMessages { get; set; }

    public virtual DbSet<DbMusteriler> DbMusterilers { get; set; }

    public virtual DbSet<DbOrder> DbOrders { get; set; }

    public virtual DbSet<DbOrderDetail> DbOrderDetails { get; set; }

    public virtual DbSet<DbOrderState> DbOrderStates { get; set; }

    public virtual DbSet<DbPage> DbPages { get; set; }

    public virtual DbSet<DbPageCategory> DbPageCategories { get; set; }

    public virtual DbSet<DbPayment> DbPayments { get; set; }

    public virtual DbSet<DbPersonel> DbPersonels { get; set; }

    public virtual DbSet<DbPicture> DbPictures { get; set; }

    public virtual DbSet<DbPoss> DbPosses { get; set; }

    public virtual DbSet<DbProdCatMark> DbProdCatMarks { get; set; }

    public virtual DbSet<DbProdCategory> DbProdCategories { get; set; }

    public virtual DbSet<DbProdComment> DbProdComments { get; set; }

    public virtual DbSet<DbProduct> DbProducts { get; set; }

    public virtual DbSet<DbProductCategory> DbProductCategories { get; set; }

    public virtual DbSet<DbProductOption> DbProductOptions { get; set; }

    public virtual DbSet<DbQuestion> DbQuestions { get; set; }

    public virtual DbSet<DbRevizyonTakip> DbRevizyonTakips { get; set; }

    public virtual DbSet<DbRevizyonYorum> DbRevizyonYorums { get; set; }

    public virtual DbSet<DbSetting> DbSettings { get; set; }

    public virtual DbSet<DbShiping> DbShipings { get; set; }

    public virtual DbSet<DbSikayetAdminNotlari> DbSikayetAdminNotlaris { get; set; }

    public virtual DbSet<DbSikayetIscilikleri> DbSikayetIscilikleris { get; set; }

    public virtual DbSet<DbSikayetLog> DbSikayetLogs { get; set; }

    public virtual DbSet<DbSikayetMesajlari> DbSikayetMesajlaris { get; set; }

    public virtual DbSet<DbSikayetState> DbSikayetStates { get; set; }

    public virtual DbSet<DbSikayetTipKat> DbSikayetTipKats { get; set; }

    public virtual DbSet<DbSikayetTipleri> DbSikayetTipleris { get; set; }

    public virtual DbSet<DbSikayetler> DbSikayetlers { get; set; }

    public virtual DbSet<DbSikayetlerGrouped> DbSikayetlerGroupeds { get; set; }

    public virtual DbSet<DbSupplier> DbSuppliers { get; set; }

    public virtual DbSet<DbTempCart> DbTempCarts { get; set; }

    public virtual DbSet<DbTicket> DbTickets { get; set; }

    public virtual DbSet<DbTopluMailList> DbTopluMailLists { get; set; }

    public virtual DbSet<DbTopluMesaj> DbTopluMesajs { get; set; }

    public virtual DbSet<DbUser> DbUsers { get; set; }

    public virtual DbSet<DbUserEvent> DbUserEvents { get; set; }

    public virtual DbSet<DbVideo> DbVideos { get; set; }

    public virtual DbSet<DbVideoCat> DbVideoCats { get; set; }

    public virtual DbSet<DbVideoCategory> DbVideoCategories { get; set; }

    public virtual DbSet<DbYedekParcalar> DbYedekParcalars { get; set; }

    public virtual DbSet<DbcariHesaplar> DbcariHesaplars { get; set; }

    public virtual DbSet<Dbiletisim> Dbiletisims { get; set; }

    public virtual DbSet<Dbiller> Dbillers { get; set; }

    public virtual DbSet<IfsCari> IfsCaris { get; set; }

    public virtual DbSet<OnlineMesaj> OnlineMesajs { get; set; }

    public virtual DbSet<PilsanCustLedgerEntry437dbf0e84ff417a965dEd2bb9650972> PilsanCustLedgerEntry437dbf0e84ff417a965dEd2bb9650972s { get; set; }

    public virtual DbSet<PilsanCustomer437dbf0e84ff417a965dEd2bb9650972> PilsanCustomer437dbf0e84ff417a965dEd2bb9650972s { get; set; }

    public virtual DbSet<PilsanDetailedCustLedgEntry437dbf0e84ff417a965dEd2bb9650972> PilsanDetailedCustLedgEntry437dbf0e84ff417a965dEd2bb9650972s { get; set; }

    public virtual DbSet<PilsanPlastikSanVeTicAŞCustLedgerEntry> PilsanPlastikSanVeTicAŞCustLedgerEntries { get; set; }

    public virtual DbSet<PilsanPlastikSanVeTicAŞCustomer> PilsanPlastikSanVeTicAŞCustomers { get; set; }

    public virtual DbSet<PilsanPlastikSanVeTicAŞDetailedCustLedgEntry> PilsanPlastikSanVeTicAŞDetailedCustLedgEntries { get; set; }

    public virtual DbSet<ServisTicketNot> ServisTicketNots { get; set; }

    public virtual DbSet<ServsisTicket> ServsisTickets { get; set; }

    public virtual DbSet<SikayetSay> SikayetSays { get; set; }

    public virtual DbSet<TblApiUser> TblApiUsers { get; set; }

    public virtual DbSet<TblIfst> TblIfsts { get; set; }

    public virtual DbSet<V2021musteriselect> V2021musteriselects { get; set; }

    public virtual DbSet<V2023Product> V2023Products { get; set; }

    public virtual DbSet<V2023Siparisler> V2023Siparislers { get; set; }

    public virtual DbSet<V2023Siparisler0> V2023Siparisler0s { get; set; }

    public virtual DbSet<V2023adminsip> V2023adminsips { get; set; }

    public virtual DbSet<VAdminSiparisler> VAdminSiparislers { get; set; }

    public virtual DbSet<VAdminSiparisler1> VAdminSiparisler1s { get; set; }

    public virtual DbSet<VBayiList> VBayiLists { get; set; }

    public virtual DbSet<VDbCariler> VDbCarilers { get; set; }

    public virtual DbSet<VDbCarilerTest> VDbCarilerTests { get; set; }

    public virtual DbSet<VDbOrder> VDbOrders { get; set; }

    public virtual DbSet<VHakedisExcel> VHakedisExcels { get; set; }

    public virtual DbSet<VKullanilanMalzemeler> VKullanilanMalzemelers { get; set; }

    public virtual DbSet<VKullanilanMalzemelerE> VKullanilanMalzemelerEs { get; set; }

    public virtual DbSet<VKullanilanMalzemelerTumu> VKullanilanMalzemelerTumus { get; set; }

    public virtual DbSet<VKullanilanMalzemelerY> VKullanilanMalzemeleries { get; set; }

    public virtual DbSet<VParcaListesi> VParcaListesis { get; set; }

    public virtual DbSet<VPilsanIadeSiparisler> VPilsanIadeSiparislers { get; set; }

    public virtual DbSet<VPilsanSipari> VPilsanSiparis { get; set; }

    public virtual DbSet<VSerkanson> VSerkansons { get; set; }

    public virtual DbSet<VServisticket> VServistickets { get; set; }

    public virtual DbSet<VSikayetDetay> VSikayetDetays { get; set; }

    public virtual DbSet<VSikayetIscilikTutar> VSikayetIscilikTutars { get; set; }

    public virtual DbSet<VSikayetYolTutar> VSikayetYolTutars { get; set; }

    public virtual DbSet<VSiparisMusteriler> VSiparisMusterilers { get; set; }

    public virtual DbSet<VSiparisToplamlari> VSiparisToplamlaris { get; set; }

    public virtual DbSet<VSiparisdurumu> VSiparisdurumus { get; set; }

    public virtual DbSet<VSiparisler> VSiparislers { get; set; }

    public virtual DbSet<VSiparsSerkan> VSiparsSerkans { get; set; }

    public virtual DbSet<VTegSoftContactsToCampaign> VTegSoftContactsToCampaigns { get; set; }

    public virtual DbSet<VTegSoftDbBayiler> VTegSoftDbBayilers { get; set; }

    public virtual DbSet<VTegSoftDbMusteriler> VTegSoftDbMusterilers { get; set; }

    public virtual DbSet<VTegSoftDbSikayetler> VTegSoftDbSikayetlers { get; set; }

    public virtual DbSet<VTegSoftDbUser> VTegSoftDbUsers { get; set; }

    public virtual DbSet<VUrunler> VUrunlers { get; set; }

    public virtual DbSet<VYeniSoru> VYeniSorus { get; set; }

    public virtual DbSet<VYeniyorum> VYeniyorums { get; set; }

    public virtual DbSet<ViewArizabaglantilari> ViewArizabaglantilaris { get; set; }

    public virtual DbSet<VwOrder> VwOrders { get; set; }

    public virtual DbSet<VwPilsanTegsoft> VwPilsanTegsofts { get; set; }

    public virtual DbSet<VwSiparisDurumAktarimi> VwSiparisDurumAktarimis { get; set; }

    public virtual DbSet<VwdbOrdersTegsoft> VwdbOrdersTegsofts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=31.145.19.54;Database=DB_PilsanTS;User Id=MSSQLMASTER;Password=helloWorld1991.;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnketYeni>(entity =>
        {
            entity.ToTable("AnketYeni");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CallId).HasColumnName("callId");
            entity.Property(e => e.ModUid).HasColumnName("modUid");
            entity.Property(e => e.Moddate)
                .HasMaxLength(50)
                .HasColumnName("moddate");
            entity.Property(e => e.Numara)
                .HasMaxLength(50)
                .HasColumnName("numara");
            entity.Property(e => e.Tus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tus");
            entity.Property(e => e.UnitId).HasColumnName("unitId");
        });

        modelBuilder.Entity<CariOdeme>(entity =>
        {
            entity.HasKey(e => e.OdemeId);

            entity.ToTable("CariOdeme");

            entity.Property(e => e.OdemeId).HasColumnName("odemeID");
            entity.Property(e => e.OdemeActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("odemeActive");
            entity.Property(e => e.OdemeCariId)
                .HasMaxLength(55)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("odemeCariID");
            entity.Property(e => e.OdemeEklenmeTarih)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("odemeEklenmeTarih");
            entity.Property(e => e.OdemeOnay).HasColumnName("odemeOnay");
            entity.Property(e => e.OdemeTaksitActive).HasColumnName("odemeTaksitActive");
            entity.Property(e => e.OdemeTarih)
                .HasMaxLength(20)
                .HasColumnName("odemeTarih");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("odemeTutar");
            entity.Property(e => e.OdemeTutar5)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("odemeTutar5");
            entity.Property(e => e.OdemeUpdate)
                .HasColumnType("datetime")
                .HasColumnName("odemeUpdate");
            entity.Property(e => e.OdemeUserAdmin).HasColumnName("odemeUserAdmin");
            entity.Property(e => e.OdemeUserId).HasColumnName("odemeUserID");
        });

        modelBuilder.Entity<CatMark>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CatMarks");

            entity.Property(e => e.Expr1).HasMaxLength(255);
            entity.Property(e => e.MarkContent).HasColumnName("markContent");
            entity.Property(e => e.MarkDate)
                .HasMaxLength(50)
                .HasColumnName("markDate");
            entity.Property(e => e.MarkId).HasColumnName("markID");
            entity.Property(e => e.MarkIsActive).HasColumnName("markIsActive");
            entity.Property(e => e.MarkLanguageId).HasColumnName("markLanguageID");
            entity.Property(e => e.MarkName)
                .HasMaxLength(250)
                .HasColumnName("markName");
            entity.Property(e => e.MarkPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("markPictureURL");
            entity.Property(e => e.MarkSuppliersId).HasColumnName("markSuppliersID");
            entity.Property(e => e.Patlak1)
                .HasMaxLength(255)
                .HasColumnName("patlak1");
            entity.Property(e => e.Patlak2)
                .HasMaxLength(255)
                .HasColumnName("patlak2");
            entity.Property(e => e.Patlak3)
                .HasMaxLength(255)
                .HasColumnName("patlak3");
            entity.Property(e => e.Patlak4)
                .HasMaxLength(255)
                .HasColumnName("patlak4");
            entity.Property(e => e.Patlak5)
                .HasMaxLength(255)
                .HasColumnName("patlak5");
            entity.Property(e => e.Pdf1)
                .HasMaxLength(255)
                .HasColumnName("pdf1");
            entity.Property(e => e.Pdf2)
                .HasMaxLength(255)
                .HasColumnName("pdf2");
            entity.Property(e => e.Pdf3)
                .HasMaxLength(255)
                .HasColumnName("pdf3");
            entity.Property(e => e.Pdf4)
                .HasMaxLength(255)
                .HasColumnName("pdf4");
            entity.Property(e => e.Pdf5)
                .HasMaxLength(255)
                .HasColumnName("pdf5");
            entity.Property(e => e.PluralCount).HasColumnName("pluralCount");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdCatContent).HasColumnName("prodCatContent");
            entity.Property(e => e.ProdCatDate)
                .HasMaxLength(50)
                .HasColumnName("prodCatDate");
            entity.Property(e => e.ProdCatId).HasColumnName("prodCatID");
            entity.Property(e => e.ProdCatIsActive).HasColumnName("prodCatIsActive");
            entity.Property(e => e.ProdCatLanguageId).HasColumnName("prodCatLanguageID");
            entity.Property(e => e.ProdCatName)
                .HasMaxLength(250)
                .HasColumnName("prodCatName");
            entity.Property(e => e.ProdCatOrderCount).HasColumnName("prodCatOrderCount");
            entity.Property(e => e.ProdCatParentCategoryId).HasColumnName("prodCatParentCategoryID");
            entity.Property(e => e.ProdCatPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodCatPictureURL");
            entity.Property(e => e.ProdCatVideoCatId).HasColumnName("prodCatVideoCatID");
            entity.Property(e => e.ProdStockCode)
                .HasMaxLength(255)
                .HasColumnName("prodStockCode");
            entity.Property(e => e.ProdUrl)
                .HasMaxLength(255)
                .HasColumnName("prodURL");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount).HasColumnName("singularCount");
        });

        modelBuilder.Entity<CatProd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CatProd");

            entity.Property(e => e.CartCount).HasColumnName("cartCount");
            entity.Property(e => e.CatId).HasColumnName("catID");
            entity.Property(e => e.DbProductsProdId).HasColumnName("dbProducts.prodID");
            entity.Property(e => e.OrderCount).HasColumnName("orderCount");
            entity.Property(e => e.Pdf1)
                .HasMaxLength(255)
                .HasColumnName("pdf1");
            entity.Property(e => e.Pdf2)
                .HasMaxLength(255)
                .HasColumnName("pdf2");
            entity.Property(e => e.Pdf3)
                .HasMaxLength(255)
                .HasColumnName("pdf3");
            entity.Property(e => e.Pdf4)
                .HasMaxLength(255)
                .HasColumnName("pdf4");
            entity.Property(e => e.Pdf5)
                .HasMaxLength(255)
                .HasColumnName("pdf5");
            entity.Property(e => e.PluralCount).HasColumnName("pluralCount");
            entity.Property(e => e.ProdAlisPrice).HasColumnName("prodAlisPrice");
            entity.Property(e => e.ProdAssessId).HasColumnName("prodAssessID");
            entity.Property(e => e.ProdBannerLink)
                .HasMaxLength(255)
                .HasColumnName("prodBannerLink");
            entity.Property(e => e.ProdBannerUrl)
                .HasMaxLength(255)
                .HasColumnName("prodBannerURL");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdBayiPrice).HasColumnName("prodBayiPrice");
            entity.Property(e => e.ProdCommentIsActive).HasColumnName("prodCommentIsActive");
            entity.Property(e => e.ProdCriticStock).HasColumnName("prodCriticStock");
            entity.Property(e => e.ProdDate)
                .HasMaxLength(50)
                .HasColumnName("prodDate");
            entity.Property(e => e.ProdDescription).HasColumnName("prodDescription");
            entity.Property(e => e.ProdHomeIsActive).HasColumnName("prodHomeIsActive");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdIndirimPrice).HasColumnName("prodIndirimPrice");
            entity.Property(e => e.ProdIsActive).HasColumnName("prodIsActive");
            entity.Property(e => e.ProdLanguageId).HasColumnName("prodLanguageID");
            entity.Property(e => e.ProdMarkId).HasColumnName("prodMarkID");
            entity.Property(e => e.ProdName)
                .HasMaxLength(255)
                .HasColumnName("prodName");
            entity.Property(e => e.ProdOrderCount).HasColumnName("prodOrderCount");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.ProdSatisPrice).HasColumnName("prodSatisPrice");
            entity.Property(e => e.ProdSeoDesc)
                .HasMaxLength(255)
                .HasColumnName("prodSeoDesc");
            entity.Property(e => e.ProdSeoKeys)
                .HasMaxLength(255)
                .HasColumnName("prodSeoKeys");
            entity.Property(e => e.ProdStockCode)
                .HasMaxLength(255)
                .HasColumnName("prodStockCode");
            entity.Property(e => e.ProdStockSize).HasColumnName("prodStockSize");
            entity.Property(e => e.ProdTavsiyePrice).HasColumnName("prodTavsiyePrice");
            entity.Property(e => e.ProdVergiId).HasColumnName("prodVergiID");
            entity.Property(e => e.ProdVideoCatId).HasColumnName("prodVideoCatID");
            entity.Property(e => e.ProdVisitedCount).HasColumnName("prodVisitedCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount).HasColumnName("singularCount");
            entity.Property(e => e.TicketCount).HasColumnName("ticketCount");
        });

        modelBuilder.Entity<DbAdminModule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbAdminModules");

            entity.Property(e => e.ModuleDescription).HasColumnName("moduleDescription");
            entity.Property(e => e.ModuleId)
                .ValueGeneratedOnAdd()
                .HasColumnName("moduleID");
            entity.Property(e => e.ModuleIsActive).HasColumnName("moduleIsActive");
            entity.Property(e => e.ModuleListId).HasColumnName("moduleListID");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(255)
                .HasColumnName("moduleName");
            entity.Property(e => e.ModulePictureUrl)
                .HasMaxLength(255)
                .HasColumnName("modulePictureURL");
            entity.Property(e => e.ModuleScriptUrl)
                .HasMaxLength(255)
                .HasColumnName("moduleScriptURL");
        });

        modelBuilder.Entity<DbAnket>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbAnket");

            entity.Property(e => e.AnketCatId).HasColumnName("anketCatID");
            entity.Property(e => e.AnketCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("anketCount");
            entity.Property(e => e.AnketDate)
                .HasColumnType("datetime")
                .HasColumnName("anketDate");
            entity.Property(e => e.AnketId).HasColumnName("anketID");
            entity.Property(e => e.AnketInput)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketInput");
            entity.Property(e => e.AnketIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketIsActive");
            entity.Property(e => e.AnketLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketLanguageID");
            entity.Property(e => e.AnketSoru)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("anketSoru");
        });

        modelBuilder.Entity<DbAnketCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbAnketCategories");

            entity.Property(e => e.AnketCatDate)
                .HasMaxLength(50)
                .HasColumnName("anketCatDate");
            entity.Property(e => e.AnketCatId)
                .ValueGeneratedOnAdd()
                .HasColumnName("anketCatID");
            entity.Property(e => e.AnketCatIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketCatIsActive");
            entity.Property(e => e.AnketCatLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketCatLanguageID");
            entity.Property(e => e.AnketCatName)
                .HasMaxLength(250)
                .HasColumnName("anketCatName");
            entity.Property(e => e.AnketCatOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("anketCatOrderCount");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
        });

        modelBuilder.Entity<DbAnketHazirCevap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbAnketHazirCevap");

            entity.Property(e => e.AnketCevId)
                .ValueGeneratedOnAdd()
                .HasColumnName("anketCevID");
            entity.Property(e => e.AnketCevIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketCevIsActive");
            entity.Property(e => e.AnketCevName)
                .HasMaxLength(250)
                .HasColumnName("anketCevName");
            entity.Property(e => e.AnketCevNameId).HasColumnName("anketCevNameID");
            entity.Property(e => e.AnketId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketID");
        });

        modelBuilder.Entity<DbAnketcvp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbAnketcvp");

            entity.Property(e => e.AnketId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketID");
            entity.Property(e => e.CvpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("cvpID");
            entity.Property(e => e.KatilimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("katilim_tarihi");
            entity.Property(e => e.SikayetId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sikayetID");
            entity.Property(e => e.Yaniticerik).HasColumnName("yaniticerik");
        });

        modelBuilder.Entity<DbAnketcvpAlt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbAnketcvp_alt");

            entity.Property(e => e.AnketCevId).HasColumnName("anketCevID");
            entity.Property(e => e.AnketId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("anketID");
            entity.Property(e => e.CvpId).HasColumnName("cvpID");
        });

        modelBuilder.Entity<DbAssessment>(entity =>
        {
            entity.HasKey(e => e.AssessId);

            entity.ToTable("dbAssessments");

            entity.Property(e => e.AssessId).HasColumnName("assessID");
            entity.Property(e => e.AssessName)
                .HasMaxLength(255)
                .HasColumnName("assessName");
            entity.Property(e => e.AssessRate).HasColumnName("assessRate");
        });

        modelBuilder.Entity<DbBank>(entity =>
        {
            entity.HasKey(e => e.BankId);

            entity.ToTable("dbBanks");

            entity.Property(e => e.BankId).HasColumnName("bankID");
            entity.Property(e => e.BankHesapIban)
                .HasMaxLength(255)
                .HasColumnName("bankHesapIBAN");
            entity.Property(e => e.BankHesapName)
                .HasMaxLength(255)
                .HasColumnName("bankHesapName");
            entity.Property(e => e.BankHesapNo).HasColumnName("bankHesapNo");
            entity.Property(e => e.BankHesapType)
                .HasMaxLength(255)
                .HasColumnName("bankHesapType");
            entity.Property(e => e.BankIsActive).HasColumnName("bankIsActive");
            entity.Property(e => e.BankName)
                .HasMaxLength(255)
                .HasColumnName("bankName");
            entity.Property(e => e.BankSubeCode).HasColumnName("bankSubeCode");
            entity.Property(e => e.BankSubeName)
                .HasMaxLength(255)
                .HasColumnName("bankSubeName");
        });

        modelBuilder.Entity<DbBanner>(entity =>
        {
            entity.HasKey(e => e.BannerId);

            entity.ToTable("dbBanner");

            entity.Property(e => e.BannerId).HasColumnName("bannerID");
            entity.Property(e => e.BannerBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("bannerBaslangicTarihi");
            entity.Property(e => e.BannerBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("bannerBitisTarihi");
            entity.Property(e => e.BannerDate)
                .HasColumnType("datetime")
                .HasColumnName("bannerDate");
            entity.Property(e => e.BannerDescription).HasColumnName("bannerDescription");
            entity.Property(e => e.BannerIcerikId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bannerIcerikID");
            entity.Property(e => e.BannerIcerikTablo)
                .HasMaxLength(255)
                .HasColumnName("bannerIcerikTablo");
            entity.Property(e => e.BannerIsActive).HasColumnName("bannerIsActive");
            entity.Property(e => e.BannerLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bannerLanguageID");
            entity.Property(e => e.BannerLinkUrl)
                .HasMaxLength(255)
                .HasColumnName("bannerLinkURL");
            entity.Property(e => e.BannerLocation)
                .HasMaxLength(255)
                .HasColumnName("bannerLocation");
            entity.Property(e => e.BannerOrderCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bannerOrderCount");
            entity.Property(e => e.BannerPageId).HasColumnName("bannerPageID");
            entity.Property(e => e.BannerPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("bannerPictureURL");
            entity.Property(e => e.BannerTitle)
                .HasMaxLength(255)
                .HasColumnName("bannerTitle");
            entity.Property(e => e.BannerTitleShowIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bannerTitleShowIsActive");
            entity.Property(e => e.BannerVisitedCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bannerVisitedCount");
        });

        modelBuilder.Entity<DbBasvurular>(entity =>
        {
            entity.HasKey(e => e.BasvuruId);

            entity.ToTable("dbBasvurular");

            entity.Property(e => e.BasvuruId).HasColumnName("basvuruID");
            entity.Property(e => e.AdSoyad)
                .HasMaxLength(255)
                .HasColumnName("adSoyad");
            entity.Property(e => e.AldigiEgitim)
                .HasMaxLength(255)
                .HasColumnName("aldigiEgitim");
            entity.Property(e => e.AnkastreBilgi).HasColumnName("ankastreBilgi");
            entity.Property(e => e.AskerlikDurum).HasColumnName("askerlikDurum");
            entity.Property(e => e.BaktigiBolgeler)
                .HasMaxLength(255)
                .HasColumnName("baktigiBolgeler");
            entity.Property(e => e.BeyazEsyaBilgi).HasColumnName("beyazEsyaBilgi");
            entity.Property(e => e.BisikletBilgi).HasColumnName("bisikletBilgi");
            entity.Property(e => e.BolgeTercih).HasColumnName("bolgeTercih");
            entity.Property(e => e.CalisanEleman)
                .HasMaxLength(255)
                .HasColumnName("calisanEleman");
            entity.Property(e => e.Cinsiyet).HasColumnName("cinsiyet");
            entity.Property(e => e.DernekKulup).HasColumnName("dernekKulup");
            entity.Property(e => e.DigerAdres).HasColumnName("digerAdres");
            entity.Property(e => e.DogumTarihi)
                .HasMaxLength(255)
                .HasColumnName("dogumTarihi");
            entity.Property(e => e.DogumYeri)
                .HasMaxLength(255)
                .HasColumnName("dogumYeri");
            entity.Property(e => e.DukkanAlan)
                .HasMaxLength(255)
                .HasColumnName("dukkanAlan");
            entity.Property(e => e.DukkanDurum).HasColumnName("dukkanDurum");
            entity.Property(e => e.ElektrikBilgi).HasColumnName("elektrikBilgi");
            entity.Property(e => e.ElektronikBilgi).HasColumnName("elektronikBilgi");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EvAdres).HasColumnName("evAdres");
            entity.Property(e => e.EvTel)
                .HasMaxLength(255)
                .HasColumnName("evTel");
            entity.Property(e => e.Fax)
                .HasMaxLength(255)
                .HasColumnName("fax");
            entity.Property(e => e.Gsm)
                .HasMaxLength(255)
                .HasColumnName("gsm");
            entity.Property(e => e.Il).HasColumnName("il");
            entity.Property(e => e.Ilce).HasColumnName("ilce");
            entity.Property(e => e.IletisimTercih).HasColumnName("iletisimTercih");
            entity.Property(e => e.IsAdres).HasColumnName("isAdres");
            entity.Property(e => e.IsTel)
                .HasMaxLength(255)
                .HasColumnName("isTel");
            entity.Property(e => e.KlimaBilgi).HasColumnName("klimaBilgi");
            entity.Property(e => e.LiseBaslangic)
                .HasMaxLength(255)
                .HasColumnName("liseBaslangic");
            entity.Property(e => e.LiseBitis)
                .HasMaxLength(255)
                .HasColumnName("liseBitis");
            entity.Property(e => e.LiseBolum)
                .HasMaxLength(255)
                .HasColumnName("liseBolum");
            entity.Property(e => e.LiseMezDerece)
                .HasMaxLength(255)
                .HasColumnName("liseMezDerece");
            entity.Property(e => e.LiseOkul)
                .HasMaxLength(255)
                .HasColumnName("liseOkul");
            entity.Property(e => e.LiseliSayisi)
                .HasMaxLength(255)
                .HasColumnName("liseliSayisi");
            entity.Property(e => e.MahkemeDetay)
                .HasMaxLength(255)
                .HasColumnName("mahkemeDetay");
            entity.Property(e => e.MahkemeDurum).HasColumnName("mahkemeDurum");
            entity.Property(e => e.MedeniDurum).HasColumnName("medeniDurum");
            entity.Property(e => e.Meslek)
                .HasMaxLength(255)
                .HasColumnName("meslek");
            entity.Property(e => e.MotorsikletBilgi).HasColumnName("motorsikletBilgi");
            entity.Property(e => e.Msn)
                .HasMaxLength(255)
                .HasColumnName("msn");
            entity.Property(e => e.MuhendisSayisi)
                .HasMaxLength(255)
                .HasColumnName("muhendisSayisi");
            entity.Property(e => e.Myosayisi)
                .HasMaxLength(255)
                .HasColumnName("MYOSayisi");
            entity.Property(e => e.NedenPilsan).HasColumnName("nedenPilsan");
            entity.Property(e => e.OrtaklikDurum).HasColumnName("ortaklikDurum");
            entity.Property(e => e.PcDurum).HasColumnName("pcDurum");
            entity.Property(e => e.Ref1AdSoyad)
                .HasMaxLength(255)
                .HasColumnName("ref1AdSoyad");
            entity.Property(e => e.Ref1Sirket)
                .HasMaxLength(255)
                .HasColumnName("ref1Sirket");
            entity.Property(e => e.Ref1Telefon)
                .HasMaxLength(255)
                .HasColumnName("ref1Telefon");
            entity.Property(e => e.Ref2AdSoyad)
                .HasMaxLength(255)
                .HasColumnName("ref2AdSoyad");
            entity.Property(e => e.Ref2Sirket)
                .HasMaxLength(255)
                .HasColumnName("ref2Sirket");
            entity.Property(e => e.Ref2Telefon)
                .HasMaxLength(255)
                .HasColumnName("ref2Telefon");
            entity.Property(e => e.Ref3AdSoyad)
                .HasMaxLength(255)
                .HasColumnName("ref3AdSoyad");
            entity.Property(e => e.Ref3Sirket)
                .HasMaxLength(255)
                .HasColumnName("ref3Sirket");
            entity.Property(e => e.Ref3Telefon)
                .HasMaxLength(255)
                .HasColumnName("ref3Telefon");
            entity.Property(e => e.Ref4AdSoyad)
                .HasMaxLength(255)
                .HasColumnName("ref4AdSoyad");
            entity.Property(e => e.Ref4Sirket)
                .HasMaxLength(255)
                .HasColumnName("ref4Sirket");
            entity.Property(e => e.Ref4Telefon)
                .HasMaxLength(255)
                .HasColumnName("ref4Telefon");
            entity.Property(e => e.SaglikDetay)
                .HasMaxLength(255)
                .HasColumnName("saglikDetay");
            entity.Property(e => e.SaglikDurum).HasColumnName("saglikDurum");
            entity.Property(e => e.SirketAdi)
                .HasMaxLength(255)
                .HasColumnName("sirketAdi");
            entity.Property(e => e.SozlesmeOnay).HasColumnName("sozlesmeOnay");
            entity.Property(e => e.TecilTarih)
                .HasMaxLength(255)
                .HasColumnName("tecilTarih");
            entity.Property(e => e.TeminatDurumu).HasColumnName("teminatDurumu");
            entity.Property(e => e.TesisatBilgi).HasColumnName("tesisatBilgi");
            entity.Property(e => e.TseKapsamlar)
                .HasMaxLength(255)
                .HasColumnName("tseKapsamlar");
            entity.Property(e => e.Tsehyb).HasColumnName("tsehyb");
            entity.Property(e => e.UniversiteBaslangic)
                .HasMaxLength(255)
                .HasColumnName("universiteBaslangic");
            entity.Property(e => e.UniversiteBitis)
                .HasMaxLength(255)
                .HasColumnName("universiteBitis");
            entity.Property(e => e.UniversiteBolum)
                .HasMaxLength(255)
                .HasColumnName("universiteBolum");
            entity.Property(e => e.UniversiteMezDerece)
                .HasMaxLength(255)
                .HasColumnName("universiteMezDerece");
            entity.Property(e => e.UniversiteOkul)
                .HasMaxLength(255)
                .HasColumnName("universiteOkul");
            entity.Property(e => e.Uyrugu)
                .HasMaxLength(255)
                .HasColumnName("uyrugu");
            entity.Property(e => e.VasitaDetay)
                .HasMaxLength(255)
                .HasColumnName("vasitaDetay");
            entity.Property(e => e.VasitaDurum).HasColumnName("vasitaDurum");
            entity.Property(e => e.VergiTuru).HasColumnName("vergiTuru");
            entity.Property(e => e.YabanciDil).HasColumnName("yabanciDil");
            entity.Property(e => e.YabanciDiller)
                .HasMaxLength(255)
                .HasColumnName("yabanciDiller");
            entity.Property(e => e.YaptigiIsler)
                .HasMaxLength(255)
                .HasColumnName("yaptigiIsler");
            entity.Property(e => e.YetkiliServisDahaOnce).HasColumnName("yetkiliServisDahaOnce");
            entity.Property(e => e.YetkiliServisFirmalar)
                .HasMaxLength(255)
                .HasColumnName("yetkiliServisFirmalar");
            entity.Property(e => e.YetkiliServisSuAn).HasColumnName("yetkiliServisSuAn");
            entity.Property(e => e.YuksOkulBaslangic)
                .HasMaxLength(255)
                .HasColumnName("yuksOkulBaslangic");
            entity.Property(e => e.YuksOkulBitis)
                .HasMaxLength(255)
                .HasColumnName("yuksOkulBitis");
            entity.Property(e => e.YuksOkulBolum)
                .HasMaxLength(255)
                .HasColumnName("yuksOkulBolum");
            entity.Property(e => e.YuksOkulMezDerece)
                .HasMaxLength(255)
                .HasColumnName("yuksOkulMezDerece");
            entity.Property(e => e.YuksOkulOkul)
                .HasMaxLength(255)
                .HasColumnName("yuksOkulOkul");
        });

        modelBuilder.Entity<DbBayiler>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("dbBayiler");

            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.Aktif)
                .HasDefaultValueSql("((1))")
                .HasColumnName("aktif");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.FaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("faturaAdSoyad");
            entity.Property(e => e.FaturaCentId).HasColumnName("faturaCentID");
            entity.Property(e => e.FaturaContent).HasColumnName("faturaContent");
            entity.Property(e => e.FaturaDistrictId).HasColumnName("faturaDistrictID");
            entity.Property(e => e.FaturaTelNo)
                .HasMaxLength(11)
                .HasColumnName("faturaTelNo");
            entity.Property(e => e.IfsCariKodu)
                .HasMaxLength(50)
                .HasColumnName("ifs_cari_kodu");
            entity.Property(e => e.IfsSevkAdresi)
                .HasMaxLength(50)
                .HasColumnName("ifs_sevk_adresi");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.TeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("teslimatAdSoyad");
            entity.Property(e => e.TeslimatCentId).HasColumnName("teslimatCentID");
            entity.Property(e => e.TeslimatContent).HasColumnName("teslimatContent");
            entity.Property(e => e.TeslimatDistrictId).HasColumnName("teslimatDistrictID");
            entity.Property(e => e.TeslimatTelNo)
                .HasMaxLength(11)
                .HasColumnName("teslimatTelNo");
            entity.Property(e => e.UserBirthDate)
                .HasColumnType("datetime")
                .HasColumnName("userBirthDate");
            entity.Property(e => e.UserCentId).HasColumnName("userCentID");
            entity.Property(e => e.UserDistrictId).HasColumnName("userDistrictID");
            entity.Property(e => e.UserFirstLogin)
                .HasDefaultValueSql("((1))")
                .HasColumnName("userFirstLogin");
            entity.Property(e => e.UserGuid)
                .HasMaxLength(255)
                .HasColumnName("userGUID");
            entity.Property(e => e.UserIp)
                .HasMaxLength(255)
                .HasColumnName("userIP");
            entity.Property(e => e.UserIsActive).HasColumnName("userIsActive");
            entity.Property(e => e.UserKimlikNo)
                .HasMaxLength(11)
                .HasColumnName("userKimlikNo");
            entity.Property(e => e.UserLastLoginDate)
                .HasColumnType("datetime")
                .HasColumnName("userLastLoginDate");
            entity.Property(e => e.UserMail)
                .HasMaxLength(255)
                .HasColumnName("userMail");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
            entity.Property(e => e.UserParentId).HasColumnName("userParentID");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasColumnName("userPass");
            entity.Property(e => e.UserPbeden)
                .HasMaxLength(255)
                .HasColumnName("userPBeden");
            entity.Property(e => e.UserPriceType)
                .HasMaxLength(255)
                .HasColumnName("userPriceType");
            entity.Property(e => e.UserTalimatIsActive).HasColumnName("userTalimatIsActive");
            entity.Property(e => e.UserTbeden)
                .HasMaxLength(255)
                .HasColumnName("userTBeden");
            entity.Property(e => e.UserTegSoftConId)
                .HasMaxLength(200)
                .HasColumnName("userTegSoftConID");
            entity.Property(e => e.UserTel1)
                .HasMaxLength(11)
                .HasColumnName("userTel1");
            entity.Property(e => e.UserTel2)
                .HasMaxLength(11)
                .HasColumnName("userTel2");
            entity.Property(e => e.UserTel3)
                .HasMaxLength(11)
                .HasColumnName("userTel3");
            entity.Property(e => e.UserType).HasColumnName("userType");
            entity.Property(e => e.UserVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("userVergiDairesi");
            entity.Property(e => e.UserVergiNo)
                .HasMaxLength(10)
                .HasColumnName("userVergiNo");
        });

        modelBuilder.Entity<DbBlog>(entity =>
        {
            entity.HasKey(e => e.BlogId);

            entity.ToTable("dbBlog");

            entity.Property(e => e.BlogId).HasColumnName("blogID");
            entity.Property(e => e.BlogBannerLink)
                .HasMaxLength(255)
                .HasColumnName("blogBannerLink");
            entity.Property(e => e.BlogBannerUrl)
                .HasMaxLength(255)
                .HasColumnName("blogBannerURL");
            entity.Property(e => e.BlogCategoryId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogCategoryID");
            entity.Property(e => e.BlogContent).HasColumnName("blogContent");
            entity.Property(e => e.BlogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("blogDate");
            entity.Property(e => e.BlogGalCatId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogGalCatID");
            entity.Property(e => e.BlogGizlilik)
                .HasMaxLength(255)
                .HasColumnName("blogGizlilik");
            entity.Property(e => e.BlogHomeIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogHomeIsActive");
            entity.Property(e => e.BlogIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogIsActive");
            entity.Property(e => e.BlogIsDelete)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogIsDelete");
            entity.Property(e => e.BlogIsUpDate)
                .HasColumnType("datetime")
                .HasColumnName("blogIsUpDate");
            entity.Property(e => e.BlogLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogLanguageID");
            entity.Property(e => e.BlogMenuIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogMenuIsActive");
            entity.Property(e => e.BlogName).HasColumnName("blogName");
            entity.Property(e => e.BlogOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("blogOrderCount");
            entity.Property(e => e.BlogPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("blogPictureURL");
            entity.Property(e => e.BlogProdCat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogProdCat");
            entity.Property(e => e.BlogTitle).HasColumnName("blogTitle");
            entity.Property(e => e.BlogUserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogUserID");
            entity.Property(e => e.BlogVideoCatId).HasColumnName("blogVideoCatID");
            entity.Property(e => e.BlogVideoId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("blogVideoID");
            entity.Property(e => e.Blogclass)
                .HasMaxLength(255)
                .HasColumnName("blogclass");
            entity.Property(e => e.Blogpdf)
                .HasMaxLength(255)
                .HasColumnName("blogpdf");
            entity.Property(e => e.LogIp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("logIP");
            entity.Property(e => e.Menuaktif).HasDefaultValueSql("((0))");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MetaKeywords).HasMaxLength(255);
            entity.Property(e => e.MetaTitle).HasMaxLength(255);
            entity.Property(e => e.ParentId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("parentID");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
        });

        modelBuilder.Entity<DbCariTest>(entity =>
        {
            entity.ToTable("dbCariTest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("aktif");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(255)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.FaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("faturaAdSoyad");
            entity.Property(e => e.FaturaCentId).HasColumnName("faturaCentID");
            entity.Property(e => e.FaturaContent)
                .HasMaxLength(255)
                .HasColumnName("faturaContent");
            entity.Property(e => e.FaturaDistrictId).HasColumnName("faturaDistrictID");
            entity.Property(e => e.FaturaTelNo)
                .HasMaxLength(255)
                .HasColumnName("faturaTelNo");
            entity.Property(e => e.PCariKod)
                .HasMaxLength(255)
                .HasColumnName("p_cari_kod");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(255)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.UserBirthDate)
                .HasMaxLength(255)
                .HasColumnName("userBirthDate");
            entity.Property(e => e.UserCentId).HasColumnName("userCentID");
            entity.Property(e => e.UserDistrictId).HasColumnName("userDistrictID");
            entity.Property(e => e.UserGuid)
                .HasMaxLength(255)
                .HasColumnName("userGUID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserIsActive).HasColumnName("userIsActive");
            entity.Property(e => e.UserKimlikNo)
                .HasMaxLength(255)
                .HasColumnName("userKimlikNo");
            entity.Property(e => e.UserLastLoginDate)
                .HasMaxLength(255)
                .HasColumnName("userLastLoginDate");
            entity.Property(e => e.UserMail)
                .HasMaxLength(255)
                .HasColumnName("userMail");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
            entity.Property(e => e.UserParentId).HasColumnName("userParentID");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasColumnName("userPass");
            entity.Property(e => e.UserPriceType)
                .HasMaxLength(255)
                .HasColumnName("userPriceType");
            entity.Property(e => e.UserTegSoftConId)
                .HasMaxLength(255)
                .HasColumnName("userTegSoftConID");
            entity.Property(e => e.UserType).HasColumnName("userType");
            entity.Property(e => e.UserVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("userVergiDairesi");
            entity.Property(e => e.UserVergiNo)
                .HasMaxLength(255)
                .HasColumnName("userVergiNo");
        });

        modelBuilder.Entity<DbCentry>(entity =>
        {
            entity.HasKey(e => e.CentId);

            entity.ToTable("dbCentries");

            entity.Property(e => e.CentId).HasColumnName("centID");
            entity.Property(e => e.CentName)
                .HasMaxLength(50)
                .HasColumnName("centName");
            entity.Property(e => e.CentNameTegSoft)
                .HasMaxLength(50)
                .HasColumnName("centNameTegSoft");
        });

        modelBuilder.Entity<DbContact>(entity =>
        {
            entity.HasKey(e => e.ContactId);

            entity.ToTable("dbContact");

            entity.Property(e => e.ContactId).HasColumnName("contactID");
            entity.Property(e => e.ContactContent).HasColumnName("contactContent");
            entity.Property(e => e.GoogleMap)
                .HasMaxLength(255)
                .HasColumnName("googleMap");
        });

        modelBuilder.Entity<DbDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.ToTable("dbDistricts");

            entity.Property(e => e.DistrictId).HasColumnName("districtID");
            entity.Property(e => e.DistrictCentId).HasColumnName("districtCentID");
            entity.Property(e => e.DistrictName)
                .HasMaxLength(255)
                .HasColumnName("districtName");
        });

        modelBuilder.Entity<DbDokuman>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbDokuman");

            entity.Property(e => e.Dokuman)
                .HasMaxLength(255)
                .HasColumnName("dokuman");
            entity.Property(e => e.DokumanBayiId).HasColumnName("dokumanBayiID");
            entity.Property(e => e.DokumanDurum).HasColumnName("dokumanDurum");
            entity.Property(e => e.DokumanId)
                .ValueGeneratedOnAdd()
                .HasColumnName("dokumanID");
            entity.Property(e => e.DokumanKef).HasColumnName("dokumanKef");
            entity.Property(e => e.DokumanTarih)
                .HasColumnType("datetime")
                .HasColumnName("dokumanTarih");
            entity.Property(e => e.DokumanUserId).HasColumnName("dokumanUserID");
            entity.Property(e => e.DokumanUserIp)
                .HasMaxLength(255)
                .HasColumnName("dokumanUserIP");
            entity.Property(e => e.DokumanUserTc).HasColumnName("dokumanUserTC");
        });

        modelBuilder.Entity<DbEvent>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("dbEvents");

            entity.Property(e => e.PageId).HasColumnName("pageID");
            entity.Property(e => e.PageContent).HasColumnName("pageContent");
            entity.Property(e => e.PageDate)
                .HasColumnType("datetime")
                .HasColumnName("pageDate");
            entity.Property(e => e.PageFinishDate)
                .HasMaxLength(255)
                .HasColumnName("pageFinishDate");
            entity.Property(e => e.PageIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageIsActive");
            entity.Property(e => e.PageLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageLanguageID");
            entity.Property(e => e.PageName)
                .HasMaxLength(150)
                .HasColumnName("pageName");
            entity.Property(e => e.PageOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("pageOrderCount");
            entity.Property(e => e.PagePictureUrl)
                .HasMaxLength(255)
                .HasColumnName("pagePictureURL");
            entity.Property(e => e.PageStartDate)
                .HasMaxLength(255)
                .HasColumnName("pageStartDate");
            entity.Property(e => e.PageVideoCatId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageVideoCatID");
            entity.Property(e => e.PageVisitedCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageVisitedCount");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
        });

        modelBuilder.Entity<DbFaturaDonemleri>(entity =>
        {
            entity.HasKey(e => e.DonemId);

            entity.ToTable("dbFaturaDonemleri", tb => tb.HasTrigger("TRG_InsertSyncFaturaDonemleri"));

            entity.Property(e => e.DonemId).HasColumnName("donemID");
            entity.Property(e => e.DonemFatNo)
                .HasMaxLength(255)
                .HasColumnName("donemFatNo");
            entity.Property(e => e.DonemFatTarihi)
                .HasColumnType("datetime")
                .HasColumnName("donemFatTarihi");
            entity.Property(e => e.DonemIsToplam).HasColumnName("donemIsToplam");
            entity.Property(e => e.DonemNot).HasColumnName("donemNot");
            entity.Property(e => e.DonemOdemeTuru).HasColumnName("donemOdemeTuru");
            entity.Property(e => e.DonemOdenen).HasColumnName("donemOdenen");
            entity.Property(e => e.DonemSikayetler).HasColumnName("donemSikayetler");
            entity.Property(e => e.DonemTamam)
                .HasDefaultValueSql("((0))")
                .HasColumnName("donemTamam");
            entity.Property(e => e.DonemTarih)
                .HasColumnType("datetime")
                .HasColumnName("donemTarih");
            entity.Property(e => e.DonemUserId).HasColumnName("donemUserID");
            entity.Property(e => e.DonemYolToplam).HasColumnName("donemYolToplam");
        });

        modelBuilder.Entity<DbFriend>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbFriends");

            entity.Property(e => e.FriendId)
                .ValueGeneratedOnAdd()
                .HasColumnName("friendID");
            entity.Property(e => e.FriendLangId)
                .HasMaxLength(255)
                .HasColumnName("friendLangID");
            entity.Property(e => e.FriendPageId).HasColumnName("friendPageID");
            entity.Property(e => e.FriendParentPageId).HasColumnName("friendParentPageID");
            entity.Property(e => e.FriendType)
                .HasMaxLength(255)
                .HasColumnName("friendType");
        });

        modelBuilder.Entity<DbGallery>(entity =>
        {
            entity.HasKey(e => e.RefId);

            entity.ToTable("dbGallery");

            entity.Property(e => e.RefId).HasColumnName("refID");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.RefCatId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("refCatID");
            entity.Property(e => e.RefDate)
                .HasColumnType("datetime")
                .HasColumnName("refDate");
            entity.Property(e => e.RefDescription).HasColumnName("refDescription");
            entity.Property(e => e.RefIsActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("refIsActive");
            entity.Property(e => e.RefLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("refLanguageID");
            entity.Property(e => e.RefPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("refPictureURL");
            entity.Property(e => e.RefTitle)
                .HasMaxLength(255)
                .HasColumnName("refTitle");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<DbGalleryCategory>(entity =>
        {
            entity.HasKey(e => e.RefCatId);

            entity.ToTable("dbGalleryCategories");

            entity.Property(e => e.RefCatId).HasColumnName("refCatID");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.RefCatContent).HasColumnName("refCatContent");
            entity.Property(e => e.RefCatDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("refCatDate");
            entity.Property(e => e.RefCatIsActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("refCatIsActive");
            entity.Property(e => e.RefCatLanguageId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("refCatLanguageID");
            entity.Property(e => e.RefCatName)
                .HasMaxLength(50)
                .HasColumnName("refCatName");
            entity.Property(e => e.RefCatOrderCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("refCatOrderCount");
            entity.Property(e => e.RefCatParentCategoryId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("refCatParentCategoryID");
            entity.Property(e => e.RefCatPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("refCatPictureURL");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
        });

        modelBuilder.Entity<DbIscilikTipi>(entity =>
        {
            entity.HasKey(e => e.IscilikId);

            entity.ToTable("dbIscilikTipi");

            entity.Property(e => e.IscilikId).HasColumnName("iscilikID");
            entity.Property(e => e.IscilikAciklama).HasColumnName("iscilikAciklama");
            entity.Property(e => e.IscilikAdi)
                .HasMaxLength(255)
                .HasColumnName("iscilikAdi");
            entity.Property(e => e.IscilikAktif).HasColumnName("iscilikAktif");
            entity.Property(e => e.IscilikCatId)
                .HasMaxLength(255)
                .HasColumnName("iscilikCatID");
            entity.Property(e => e.IscilikGarantiDurum).HasColumnName("iscilikGarantiDurum");
            entity.Property(e => e.IscilikGecerlilikTarih10)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih10");
            entity.Property(e => e.IscilikGecerlilikTarih11)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih11");
            entity.Property(e => e.IscilikGecerlilikTarih2)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih2");
            entity.Property(e => e.IscilikGecerlilikTarih4)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih4");
            entity.Property(e => e.IscilikGecerlilikTarih5)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih5");
            entity.Property(e => e.IscilikGecerlilikTarih6)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih6");
            entity.Property(e => e.IscilikGecerlilikTarih7)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih7");
            entity.Property(e => e.IscilikGecerlilikTarih8)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih8");
            entity.Property(e => e.IscilikGecerlilikTarih9)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarih9");
            entity.Property(e => e.IscilikGecerlilikTarihi)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarihi");
            entity.Property(e => e.IscilikGecerlilikTarihi1)
                .HasColumnType("date")
                .HasColumnName("iscilikGecerlilikTarihi1");
            entity.Property(e => e.IscilikHizmetTuru).HasColumnName("iscilikHizmetTuru");
            entity.Property(e => e.IscilikInputId).HasColumnName("iscilikInputID");
            entity.Property(e => e.IscilikKodu)
                .HasMaxLength(255)
                .HasColumnName("iscilikKodu");
            entity.Property(e => e.IscilikUcret).HasColumnName("iscilikUcret");
            entity.Property(e => e.IscilikUcret1).HasColumnName("iscilikUcret1");
            entity.Property(e => e.IscilikUcret10).HasColumnName("iscilikUcret10");
            entity.Property(e => e.IscilikUcret11).HasColumnName("iscilikUcret11");
            entity.Property(e => e.IscilikUcret2).HasColumnName("iscilikUcret2");
            entity.Property(e => e.IscilikUcret3).HasColumnName("iscilikUcret3");
            entity.Property(e => e.IscilikUcret4).HasColumnName("iscilikUcret4");
            entity.Property(e => e.IscilikUcret5).HasColumnName("iscilikUcret5");
            entity.Property(e => e.IscilikUcret6).HasColumnName("iscilikUcret6");
            entity.Property(e => e.IscilikUcret7).HasColumnName("iscilikUcret7");
            entity.Property(e => e.IscilikUcret8).HasColumnName("iscilikUcret8");
            entity.Property(e => e.IscilikUcret9).HasColumnName("iscilikUcret9");
            entity.Property(e => e.IscilikUcretKimden).HasColumnName("iscilikUcretKimden");
        });

        modelBuilder.Entity<DbKullaniciTanimlari>(entity =>
        {
            entity.HasKey(e => e.TanimId);

            entity.ToTable("dbKullaniciTanimlari");

            entity.Property(e => e.TanimId).HasColumnName("tanimID");
            entity.Property(e => e.TanimAciklama).HasColumnName("tanimAciklama");
            entity.Property(e => e.TanimAdi)
                .HasMaxLength(255)
                .HasColumnName("tanimAdi");
            entity.Property(e => e.TanimIndirimOrani).HasColumnName("tanimIndirimOrani");
        });

        modelBuilder.Entity<DbKullanilanMalzemeler>(entity =>
        {
            entity.HasKey(e => e.KulId);

            entity.ToTable("dbKullanilanMalzemeler");

            entity.Property(e => e.KulId).HasColumnName("kulID");
            entity.Property(e => e.KulGarantiIsActive).HasColumnName("kulGarantiIsActive");
            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.No)
                .HasMaxLength(255)
                .HasColumnName("no_");
            entity.Property(e => e.ProdAdet).HasColumnName("prodAdet");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdFiyat).HasColumnName("prodFiyat");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdOptId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodOptID");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("recordDate");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<DbKullanilanParcalar>(entity =>
        {
            entity.ToTable("dbKullanilanParcalar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("aciklama");
            entity.Property(e => e.BirimFiyat).HasColumnName("birim_fiyat");
            entity.Property(e => e.DonemId).HasColumnName("donemID");
            entity.Property(e => e.KulGarantiIsActive).HasColumnName("kulGarantiIsActive");
            entity.Property(e => e.Miktar).HasColumnName("miktar");
            entity.Property(e => e.NavAktar).HasColumnName("Nav_aktar");
            entity.Property(e => e.ProdNo)
                .HasMaxLength(255)
                .HasColumnName("prodNo");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
        });

        modelBuilder.Entity<DbLanguage>(entity =>
        {
            entity.HasKey(e => e.LangId);

            entity.ToTable("dbLanguages");

            entity.Property(e => e.LangId).HasColumnName("langID");
            entity.Property(e => e.LangName)
                .HasMaxLength(50)
                .HasColumnName("langName");
            entity.Property(e => e.LangSembol)
                .HasMaxLength(255)
                .HasColumnName("langSembol");
            entity.Property(e => e.LangWebLogo).HasColumnName("langWebLogo");
        });

        modelBuilder.Entity<DbLisan>(entity =>
        {
            entity.HasKey(e => e.LowId);

            entity.ToTable("dbLisan");

            entity.Property(e => e.LowId).HasColumnName("lowID");
            entity.Property(e => e.LowAciklama)
                .HasMaxLength(50)
                .HasColumnName("lowAciklama");
            entity.Property(e => e.LowDesc).HasColumnName("lowDesc");
            entity.Property(e => e.LowIsActive).HasColumnName("lowIsActive");
            entity.Property(e => e.LowLangId).HasColumnName("lowLangID");
            entity.Property(e => e.LowParId).HasColumnName("lowParID");
        });

        modelBuilder.Entity<DbLogger>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("dbLoggers");

            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.LogBrowser)
                .HasMaxLength(255)
                .HasColumnName("logBrowser");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("logDate");
            entity.Property(e => e.LogIp)
                .HasMaxLength(255)
                .HasColumnName("logIP");
            entity.Property(e => e.LogUserId).HasColumnName("logUserID");
            entity.Property(e => e.LogUserName)
                .HasMaxLength(255)
                .HasColumnName("logUserName");
            entity.Property(e => e.LogoutDate)
                .HasMaxLength(55)
                .HasColumnName("logoutDate");
            entity.Property(e => e.PersonelActive).HasColumnName("personelActive");
            entity.Property(e => e.PersonelAdi)
                .HasMaxLength(255)
                .HasColumnName("personelAdi");
            entity.Property(e => e.PersonelId).HasColumnName("personelID");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<DbLow>(entity =>
        {
            entity.HasKey(e => e.LowId);

            entity.ToTable("dbLOW");

            entity.Property(e => e.LowId).HasColumnName("lowID");
            entity.Property(e => e.LowCatId).HasColumnName("lowCatID");
            entity.Property(e => e.LowDesc)
                .HasMaxLength(255)
                .HasColumnName("lowDesc");
            entity.Property(e => e.LowIsActive).HasColumnName("lowIsActive");
            entity.Property(e => e.LowLang).HasColumnName("lowLang");
            entity.Property(e => e.LowSortOrtder).HasColumnName("lowSortOrtder");
        });

        modelBuilder.Entity<DbLowcat>(entity =>
        {
            entity.HasKey(e => e.LowCatId);

            entity.ToTable("dbLOWCat");

            entity.Property(e => e.LowCatId).HasColumnName("lowCatID");
            entity.Property(e => e.LowCatDesc)
                .HasMaxLength(255)
                .HasColumnName("lowCatDesc");
        });

        modelBuilder.Entity<DbMail>(entity =>
        {
            entity.HasKey(e => e.MailId);

            entity.ToTable("dbMails");

            entity.Property(e => e.MailId).HasColumnName("mailID");
            entity.Property(e => e.MailContent).HasColumnName("mailContent");
            entity.Property(e => e.MailDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("mailDate");
            entity.Property(e => e.MailSubject)
                .HasMaxLength(255)
                .HasColumnName("mailSubject");
            entity.Property(e => e.MailUsers).HasColumnName("mailUsers");
        });

        modelBuilder.Entity<DbMailList>(entity =>
        {
            entity.HasKey(e => e.MailId);

            entity.ToTable("dbMailList");

            entity.Property(e => e.MailId).HasColumnName("mailID");
            entity.Property(e => e.MailDate)
                .HasMaxLength(255)
                .HasColumnName("mailDate");
            entity.Property(e => e.MailIp)
                .HasMaxLength(50)
                .HasColumnName("mailIP");
            entity.Property(e => e.MailName)
                .HasMaxLength(255)
                .HasColumnName("mailName");
        });

        modelBuilder.Entity<DbMark>(entity =>
        {
            entity.HasKey(e => e.MarkId);

            entity.ToTable("dbMarks");

            entity.Property(e => e.MarkId).HasColumnName("markID");
            entity.Property(e => e.MarkContent).HasColumnName("markContent");
            entity.Property(e => e.MarkDate)
                .HasColumnType("datetime")
                .HasColumnName("markDate");
            entity.Property(e => e.MarkIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("markIsActive");
            entity.Property(e => e.MarkLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("markLanguageID");
            entity.Property(e => e.MarkName)
                .HasMaxLength(250)
                .HasColumnName("markName");
            entity.Property(e => e.MarkPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("markPictureURL");
            entity.Property(e => e.MarkSuppliersId).HasColumnName("markSuppliersID");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
        });

        modelBuilder.Entity<DbMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("dbMenus");

            entity.Property(e => e.MenuId).HasColumnName("menuID");
            entity.Property(e => e.MenuAuthIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("menuAuthIsActive");
            entity.Property(e => e.MenuIsActive).HasColumnName("menuIsActive");
            entity.Property(e => e.MenuIsDate)
                .HasColumnType("datetime")
                .HasColumnName("menuIsDate");
            entity.Property(e => e.MenuIsUpDate)
                .HasColumnType("datetime")
                .HasColumnName("menuIsUpDate");
            entity.Property(e => e.MenuLangId).HasColumnName("menuLangID");
            entity.Property(e => e.MenuLocation)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("menuLocation");
            entity.Property(e => e.MenuName)
                .HasMaxLength(255)
                .HasColumnName("menuName");
            entity.Property(e => e.MenuOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("menuOrderCount");
            entity.Property(e => e.MenuParentId).HasColumnName("menuParentID");
            entity.Property(e => e.MenuUrl)
                .HasMaxLength(255)
                .HasColumnName("menuURL");
        });

        modelBuilder.Entity<DbMenuList>(entity =>
        {
            entity.HasKey(e => e.AdMenuId);

            entity.ToTable("dbMenuList");

            entity.Property(e => e.AdMenuId).HasColumnName("adMenuID");
            entity.Property(e => e.AdMenuDesc)
                .HasMaxLength(255)
                .HasColumnName("adMenuDesc");
            entity.Property(e => e.AdMenuIsActive).HasColumnName("adMenuIsActive");
            entity.Property(e => e.AdMenuName)
                .HasMaxLength(255)
                .HasColumnName("adMenuName");
            entity.Property(e => e.AdMenuOrderCount).HasColumnName("adMenuOrderCount");
            entity.Property(e => e.AdMenuPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("adMenuPictureURL");
            entity.Property(e => e.AdMenuUrl)
                .HasMaxLength(255)
                .HasColumnName("adMenuURL");
            entity.Property(e => e.AdMenustIsActive).HasColumnName("adMenustIsActive");
            entity.Property(e => e.AdmenuParentId).HasColumnName("admenuParentID");
        });

        modelBuilder.Entity<DbMenuListNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbMenuListNew");

            entity.Property(e => e.AdMenuDesc)
                .HasMaxLength(255)
                .HasColumnName("adMenuDesc");
            entity.Property(e => e.AdMenuId)
                .ValueGeneratedOnAdd()
                .HasColumnName("adMenuID");
            entity.Property(e => e.AdMenuIsActive).HasColumnName("adMenuIsActive");
            entity.Property(e => e.AdMenuName)
                .HasMaxLength(255)
                .HasColumnName("adMenuName");
            entity.Property(e => e.AdMenuOrderCount).HasColumnName("adMenuOrderCount");
            entity.Property(e => e.AdMenuPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("adMenuPictureURL");
            entity.Property(e => e.AdMenuUrl)
                .HasMaxLength(255)
                .HasColumnName("adMenuURL");
            entity.Property(e => e.AdMenustIsActive).HasColumnName("adMenustIsActive");
            entity.Property(e => e.AdmenuParentId).HasColumnName("admenuParentID");
        });

        modelBuilder.Entity<DbMessage>(entity =>
        {
            entity.HasKey(e => e.MesId);

            entity.ToTable("dbMessages");

            entity.Property(e => e.MesId).HasColumnName("mesID");
            entity.Property(e => e.MesContent).HasColumnName("mesContent");
            entity.Property(e => e.MesDate)
                .HasColumnType("datetime")
                .HasColumnName("mesDate");
            entity.Property(e => e.MesReadIsActive).HasColumnName("mesReadIsActive");
            entity.Property(e => e.MesSendUserId).HasColumnName("mesSendUserID");
            entity.Property(e => e.MesSendUserIp)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("mesSendUserIP");
            entity.Property(e => e.MesTitle)
                .HasMaxLength(255)
                .HasColumnName("mesTitle");
            entity.Property(e => e.MesUserId).HasColumnName("mesUserID");
            entity.Property(e => e.MesajSikayetId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mesajSikayetID");
            entity.Property(e => e.MesajarizaId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mesajarizaID");
        });

        modelBuilder.Entity<DbMusteriler>(entity =>
        {
            entity.HasKey(e => e.MusteriId);

            entity.ToTable("dbMusteriler");

            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.Aktif)
                .HasDefaultValueSql("((1))")
                .HasColumnName("aktif");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
            entity.Property(e => e.DeletedDate)
                .HasColumnType("datetime")
                .HasColumnName("deletedDate");
            entity.Property(e => e.FaturaAdres)
                .HasMaxLength(501)
                .HasColumnName("fatura_adres");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.FaturaIl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fatura_il");
            entity.Property(e => e.FaturaIlce)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fatura_ilce");
            entity.Property(e => e.FaturaTelefon)
                .HasMaxLength(51)
                .HasColumnName("fatura_telefon");
            entity.Property(e => e.IfsCariKodu)
                .HasMaxLength(50)
                .HasColumnName("ifs_cari_kodu");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.MusteriAdres)
                .HasMaxLength(501)
                .HasColumnName("musteri_adres");
            entity.Property(e => e.MusteriAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("musteri_adsoyad");
            entity.Property(e => e.MusteriEmail)
                .HasMaxLength(255)
                .HasColumnName("musteri_email");
            entity.Property(e => e.MusteriIl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("musteri_il");
            entity.Property(e => e.MusteriIlce)
                .HasDefaultValueSql("((0))")
                .HasColumnName("musteri_ilce");
            entity.Property(e => e.MusteriKimlikno)
                .HasMaxLength(21)
                .HasColumnName("musteri_kimlikno");
            entity.Property(e => e.MusteriTelefon)
                .HasMaxLength(51)
                .HasColumnName("musteri_telefon");
            entity.Property(e => e.MusteriVergidairesi)
                .HasMaxLength(100)
                .HasColumnName("musteri_vergidairesi");
            entity.Property(e => e.MusteriVergino)
                .HasMaxLength(21)
                .HasColumnName("musteri_vergino");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.TeslimatAdres)
                .HasMaxLength(501)
                .HasColumnName("teslimat_adres");
            entity.Property(e => e.TeslimatAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("teslimat_adsoyad");
            entity.Property(e => e.TeslimatIl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("teslimat_il");
            entity.Property(e => e.TeslimatIlce)
                .HasDefaultValueSql("((0))")
                .HasColumnName("teslimat_ilce");
            entity.Property(e => e.TeslimatTelefon)
                .HasMaxLength(51)
                .HasColumnName("teslimat_telefon");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<DbOrder>(entity =>
        {
            entity.HasKey(e => e.SiparisId);

            entity.ToTable("dbOrders");

            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.BayiId).HasColumnName("bayiID");
            entity.Property(e => e.IfsCariKodu)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ifs_cari_kodu");
            entity.Property(e => e.IfsSevkAdresi)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ifs_sevk_adresi");
            entity.Property(e => e.KargoOdeme)
                .HasMaxLength(50)
                .HasColumnName("kargoOdeme");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.SalesType)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Sales_Type");
            entity.Property(e => e.Sebep)
                .HasColumnType("text")
                .HasColumnName("sebep");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisBankName)
                .HasMaxLength(255)
                .HasColumnName("siparisBankName");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisFaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaAdSoyad");
            entity.Property(e => e.SiparisFaturaAdresi).HasColumnName("siparisFaturaAdresi");
            entity.Property(e => e.SiparisFaturaIlce).HasColumnName("siparisFaturaIlce");
            entity.Property(e => e.SiparisFaturaNo)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaNo");
            entity.Property(e => e.SiparisFaturaSehir).HasColumnName("siparisFaturaSehir");
            entity.Property(e => e.SiparisFaturaTelNo)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaTelNo");
            entity.Property(e => e.SiparisGuncellemeTarihi)
                .HasMaxLength(50)
                .HasColumnName("siparisGuncellemeTarihi");
            entity.Property(e => e.SiparisIndirimOrani)
                .HasDefaultValueSql("((0))")
                .HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisIp)
                .HasMaxLength(255)
                .HasColumnName("siparisIP");
            entity.Property(e => e.SiparisKapidaOdeme)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("siparisKapidaOdeme");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisLogId).HasColumnName("siparisLogID");
            entity.Property(e => e.SiparisMagazaNotu).HasColumnName("siparisMagazaNotu");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisNot).HasColumnName("siparisNot");
            entity.Property(e => e.SiparisNot1).HasColumnName("siparisNot1");
            entity.Property(e => e.SiparisOdemeYontemi).HasColumnName("siparisOdemeYontemi");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisPosName)
                .HasMaxLength(255)
                .HasColumnName("siparisPosName");
            entity.Property(e => e.SiparisPosOrderId).HasColumnName("siparisPosOrderID");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisTeslimatAdres).HasColumnName("siparisTeslimatAdres");
            entity.Property(e => e.SiparisTeslimatIlce).HasColumnName("siparisTeslimatIlce");
            entity.Property(e => e.SiparisTeslimatSehir).HasColumnName("siparisTeslimatSehir");
            entity.Property(e => e.SiparisTeslimatTelNo)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatTelNo");
            entity.Property(e => e.SiparisTutar)
                .HasDefaultValueSql("((0))")
                .HasColumnName("siparisTutar");
            entity.Property(e => e.SiparisUrunler).HasColumnName("siparisUrunler");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.SiparisVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("siparisVergiDairesi");
            entity.Property(e => e.SiparisVergiNo)
                .HasMaxLength(255)
                .HasColumnName("siparisVergiNo");
            entity.Property(e => e.Sonuc)
                .HasColumnType("text")
                .HasColumnName("sonuc");
            entity.Property(e => e.TGuncel).HasColumnName("tGuncel");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<DbOrderDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId);

            entity.ToTable("dbOrderDetails");

            entity.Property(e => e.DetailId).HasColumnName("detailID");
            entity.Property(e => e.DetailGonderilenAdet).HasColumnName("detailGonderilenAdet");
            entity.Property(e => e.DetailOrderId).HasColumnName("detailOrderID");
            entity.Property(e => e.DetailOrderTempId)
                .HasMaxLength(255)
                .HasColumnName("detailOrderTempID");
            entity.Property(e => e.DetailPlu)
                .HasMaxLength(255)
                .HasColumnName("detailPlu");
            entity.Property(e => e.DetailProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("detailProdBarcodeCode");
            entity.Property(e => e.DetailProdCount).HasColumnName("detailProdCount");
            entity.Property(e => e.DetailProdId).HasColumnName("detailProdID");
            entity.Property(e => e.DetailProdName)
                .HasMaxLength(255)
                .HasColumnName("detailProdName");
            entity.Property(e => e.DetailProdPrice)
                .HasColumnType("money")
                .HasColumnName("detailProdPrice");
            entity.Property(e => e.DetailProdPurchaseRate)
                .HasMaxLength(255)
                .HasColumnName("detailProdPurchaseRate");
            entity.Property(e => e.DetailSubProdId).HasColumnName("detailSubProdID");
            entity.Property(e => e.DetailUserId).HasColumnName("detailUserID");
            entity.Property(e => e.DetailsikayetId).HasColumnName("detailsikayetID");
            entity.Property(e => e.NavCektiMi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("nav_cekti_mi");
            entity.Property(e => e.OrderType)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Order Type");
        });

        modelBuilder.Entity<DbOrderState>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("dbOrderStates");

            entity.Property(e => e.StateId).HasColumnName("stateID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.StateName)
                .HasMaxLength(255)
                .HasColumnName("stateName");
        });

        modelBuilder.Entity<DbPage>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("dbPages");

            entity.Property(e => e.PageId).HasColumnName("pageID");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.LogIp)
                .HasMaxLength(255)
                .HasColumnName("logIP");
            entity.Property(e => e.Menuaktif).HasDefaultValueSql("((0))");
            entity.Property(e => e.MetaDescription).HasMaxLength(255);
            entity.Property(e => e.MetaKeywords).HasMaxLength(255);
            entity.Property(e => e.MetaTitle).HasMaxLength(255);
            entity.Property(e => e.PageBannerLink)
                .HasMaxLength(255)
                .HasColumnName("pageBannerLink");
            entity.Property(e => e.PageBannerUrl)
                .HasMaxLength(255)
                .HasColumnName("pageBannerURL");
            entity.Property(e => e.PageCatId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageCatID");
            entity.Property(e => e.PageContent).HasColumnName("pageContent");
            entity.Property(e => e.PageDate)
                .HasColumnType("datetime")
                .HasColumnName("pageDate");
            entity.Property(e => e.PageGalCatId).HasColumnName("pageGalCatID");
            entity.Property(e => e.PageGizlilik)
                .HasMaxLength(255)
                .HasColumnName("pageGizlilik");
            entity.Property(e => e.PageHomeIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageHomeIsActive");
            entity.Property(e => e.PageIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageIsActive");
            entity.Property(e => e.PageLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageLanguageID");
            entity.Property(e => e.PageName)
                .HasMaxLength(150)
                .HasColumnName("pageName");
            entity.Property(e => e.PageOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("pageOrderCount");
            entity.Property(e => e.PagePictureUrl)
                .HasMaxLength(255)
                .HasColumnName("pagePictureURL");
            entity.Property(e => e.PageVideoCatId).HasColumnName("pageVideoCatID");
            entity.Property(e => e.PageVisitedCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageVisitedCount");
            entity.Property(e => e.Pagepdf)
                .HasMaxLength(255)
                .HasColumnName("pagepdf");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<DbPageCategory>(entity =>
        {
            entity.HasKey(e => e.PageCatId);

            entity.ToTable("dbPageCategories");

            entity.Property(e => e.PageCatId).HasColumnName("pageCatID");
            entity.Property(e => e.PageCatContent).HasColumnName("pageCatContent");
            entity.Property(e => e.PageCatDate)
                .HasColumnType("datetime")
                .HasColumnName("pageCatDate");
            entity.Property(e => e.PageCatIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageCatIsActive");
            entity.Property(e => e.PageCatLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageCatLanguageID");
            entity.Property(e => e.PageCatName)
                .HasMaxLength(250)
                .HasColumnName("pageCatName");
            entity.Property(e => e.PageCatOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("pageCatOrderCount");
            entity.Property(e => e.PageCatParentCategoryId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pageCatParentCategoryID");
            entity.Property(e => e.PageCatPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("pageCatPictureURL");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
        });

        modelBuilder.Entity<DbPayment>(entity =>
        {
            entity.HasKey(e => e.BankIsActive);

            entity.ToTable("dbPayments");

            entity.Property(e => e.BankIsActive).HasColumnName("bankIsActive");
            entity.Property(e => e.CreditIsActive).HasColumnName("creditIsActive");
            entity.Property(e => e.KapiIsActive).HasColumnName("kapiIsActive");
            entity.Property(e => e.KapidaOdemeContent).HasColumnName("kapidaOdemeContent");
            entity.Property(e => e.PayId).HasColumnName("payID");
        });

        modelBuilder.Entity<DbPersonel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbPersonel");

            entity.Property(e => e.Kkodukpm)
                .HasMaxLength(50)
                .HasColumnName("kkodukpm");
            entity.Property(e => e.PersonelAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("personelAdSoyad");
            entity.Property(e => e.PersonelAktif).HasColumnName("personelAktif");
            entity.Property(e => e.PersonelId)
                .ValueGeneratedOnAdd()
                .HasColumnName("personelID");
            entity.Property(e => e.PersonelIp)
                .HasMaxLength(50)
                .HasColumnName("personelIP");
            entity.Property(e => e.PersonelMail)
                .HasMaxLength(255)
                .HasColumnName("personelMail");
            entity.Property(e => e.PersonelParola)
                .HasMaxLength(50)
                .HasColumnName("personelParola");
            entity.Property(e => e.PersonelSayfalar)
                .HasMaxLength(255)
                .HasColumnName("personelSayfalar");
            entity.Property(e => e.PersonelSirket)
                .HasMaxLength(50)
                .HasColumnName("personelSirket");
            entity.Property(e => e.PersonelSube).HasColumnName("personelSube");
            entity.Property(e => e.PersonelYetki)
                .HasMaxLength(50)
                .HasColumnName("personelYetki");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserLastLoginDate)
                .HasColumnType("datetime")
                .HasColumnName("userLastLoginDate");
        });

        modelBuilder.Entity<DbPicture>(entity =>
        {
            entity.HasKey(e => e.PicId);

            entity.ToTable("dbPictures");

            entity.Property(e => e.PicId).HasColumnName("picID");
            entity.Property(e => e.PictureName).HasColumnName("pictureName");
        });

        modelBuilder.Entity<DbPoss>(entity =>
        {
            entity.HasKey(e => e.PosId);

            entity.ToTable("dbPosses");

            entity.Property(e => e.PosId).HasColumnName("posID");
            entity.Property(e => e.BankaTaksitOranlari)
                .HasMaxLength(255)
                .HasColumnName("bankaTaksitOranlari");
            entity.Property(e => e.Pos3StoreKey)
                .HasMaxLength(255)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("pos3StoreKey");
            entity.Property(e => e.Pos3d).HasColumnName("pos3d");
            entity.Property(e => e.PosCartName)
                .HasMaxLength(255)
                .HasColumnName("posCartName");
            entity.Property(e => e.PosCartPassword)
                .HasMaxLength(255)
                .HasColumnName("posCartPassword");
            entity.Property(e => e.PosCartUser)
                .HasMaxLength(255)
                .HasColumnName("posCartUser");
            entity.Property(e => e.PosClientId)
                .HasMaxLength(255)
                .HasColumnName("posClientID");
            entity.Property(e => e.PosIsActive).HasColumnName("posIsActive");
            entity.Property(e => e.PosIsDefault).HasColumnName("posIsDefault");
            entity.Property(e => e.PosMagazaId)
                .HasMaxLength(255)
                .HasColumnName("posMagazaID");
            entity.Property(e => e.PosName)
                .HasMaxLength(255)
                .HasColumnName("posName");
            entity.Property(e => e.PosOrderCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("posOrderCount");
            entity.Property(e => e.PosUrl)
                .HasMaxLength(255)
                .HasColumnName("posURL");
            entity.Property(e => e.PosYontem)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("posYontem");
        });

        modelBuilder.Entity<DbProdCatMark>(entity =>
        {
            entity.HasKey(e => e.CatMarkId);

            entity.ToTable("dbProdCatMarks");

            entity.Property(e => e.CatMarkId).HasColumnName("catMarkID");
            entity.Property(e => e.CatId).HasColumnName("catID");
            entity.Property(e => e.MarkId).HasColumnName("markID");
        });

        modelBuilder.Entity<DbProdCategory>(entity =>
        {
            entity.HasKey(e => e.ProdCatId);

            entity.ToTable("dbProdCategories");

            entity.Property(e => e.ProdCatId).HasColumnName("prodCatID");
            entity.Property(e => e.Patlak1)
                .HasMaxLength(255)
                .HasColumnName("patlak1");
            entity.Property(e => e.Patlak2)
                .HasMaxLength(255)
                .HasColumnName("patlak2");
            entity.Property(e => e.Patlak3)
                .HasMaxLength(255)
                .HasColumnName("patlak3");
            entity.Property(e => e.Patlak4)
                .HasMaxLength(255)
                .HasColumnName("patlak4");
            entity.Property(e => e.Patlak5)
                .HasMaxLength(255)
                .HasColumnName("patlak5");
            entity.Property(e => e.Pdf1)
                .HasMaxLength(255)
                .HasColumnName("pdf1");
            entity.Property(e => e.Pdf2)
                .HasMaxLength(255)
                .HasColumnName("pdf2");
            entity.Property(e => e.Pdf3)
                .HasMaxLength(255)
                .HasColumnName("pdf3");
            entity.Property(e => e.Pdf4)
                .HasMaxLength(255)
                .HasColumnName("pdf4");
            entity.Property(e => e.Pdf5)
                .HasMaxLength(255)
                .HasColumnName("pdf5");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdCatContent).HasColumnName("prodCatContent");
            entity.Property(e => e.ProdCatDate)
                .HasColumnType("datetime")
                .HasColumnName("prodCatDate");
            entity.Property(e => e.ProdCatIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodCatIsActive");
            entity.Property(e => e.ProdCatLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodCatLanguageID");
            entity.Property(e => e.ProdCatName)
                .HasMaxLength(250)
                .HasColumnName("prodCatName");
            entity.Property(e => e.ProdCatOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("prodCatOrderCount");
            entity.Property(e => e.ProdCatParentCategoryId).HasColumnName("prodCatParentCategoryID");
            entity.Property(e => e.ProdCatPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodCatPictureURL");
            entity.Property(e => e.ProdCatVideoCatId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodCatVideoCatID");
            entity.Property(e => e.ProdStockCode)
                .HasMaxLength(255)
                .HasColumnName("prodStockCode");
            entity.Property(e => e.ProdUrl)
                .HasMaxLength(255)
                .HasColumnName("prodURL");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
        });

        modelBuilder.Entity<DbProdComment>(entity =>
        {
            entity.HasKey(e => e.ProdCommentId);

            entity.ToTable("dbProdComments");

            entity.Property(e => e.ProdCommentId).HasColumnName("prodCommentID");
            entity.Property(e => e.CommentTip).HasMaxLength(255);
            entity.Property(e => e.Commentdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Ipadresi)
                .HasMaxLength(255)
                .HasColumnName("IPAdresi");
            entity.Property(e => e.ProdCommentIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodCommentIsActive");
            entity.Property(e => e.ProdCommentMail)
                .HasMaxLength(50)
                .HasColumnName("prodCommentMail");
            entity.Property(e => e.ProdCommentName)
                .HasMaxLength(50)
                .HasColumnName("prodCommentName");
            entity.Property(e => e.ProdCommentText).HasColumnName("prodCommentText");
            entity.Property(e => e.ProdCommentTitle)
                .HasMaxLength(250)
                .HasColumnName("prodCommentTitle");
            entity.Property(e => e.ProdId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodID");
            entity.Property(e => e.ProdUserId).HasColumnName("prodUserID");
        });

        modelBuilder.Entity<DbProduct>(entity =>
        {
            entity.HasKey(e => e.ProdId);

            entity.ToTable("dbProducts");

            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.CartCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("cartCount");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.No)
                .HasMaxLength(50)
                .HasColumnName("No_");
            entity.Property(e => e.OrderCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("orderCount");
            entity.Property(e => e.Pdf1)
                .HasMaxLength(255)
                .HasColumnName("pdf1");
            entity.Property(e => e.Pdf2)
                .HasMaxLength(255)
                .HasColumnName("pdf2");
            entity.Property(e => e.Pdf3)
                .HasMaxLength(255)
                .HasColumnName("pdf3");
            entity.Property(e => e.Pdf4)
                .HasMaxLength(255)
                .HasColumnName("pdf4");
            entity.Property(e => e.Pdf5)
                .HasMaxLength(255)
                .HasColumnName("pdf5");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.ProdAlisPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodAlisPrice");
            entity.Property(e => e.ProdAssessId).HasColumnName("prodAssessID");
            entity.Property(e => e.ProdBannerLink)
                .HasMaxLength(255)
                .HasColumnName("prodBannerLink");
            entity.Property(e => e.ProdBannerUrl)
                .HasMaxLength(255)
                .HasColumnName("prodBannerURL");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdBayiPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodBayiPrice");
            entity.Property(e => e.ProdBirim).HasColumnName("prodBirim");
            entity.Property(e => e.ProdBirimDesc).HasColumnName("prodBirimDesc");
            entity.Property(e => e.ProdCommentIsActive).HasColumnName("prodCommentIsActive");
            entity.Property(e => e.ProdCriticStock).HasColumnName("prodCriticStock");
            entity.Property(e => e.ProdDate)
                .HasColumnType("datetime")
                .HasColumnName("prodDate");
            entity.Property(e => e.ProdDescription).HasColumnName("prodDescription");
            entity.Property(e => e.ProdHomeIsActive).HasColumnName("prodHomeIsActive");
            entity.Property(e => e.ProdIndirimPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodIndirimPrice");
            entity.Property(e => e.ProdIsActive).HasColumnName("prodIsActive");
            entity.Property(e => e.ProdLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodLanguageID");
            entity.Property(e => e.ProdMarkId).HasColumnName("prodMarkID");
            entity.Property(e => e.ProdName)
                .HasMaxLength(255)
                .HasColumnName("prodName");
            entity.Property(e => e.ProdOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("prodOrderCount");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.ProdSatisPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodSatisPrice");
            entity.Property(e => e.ProdSeoDesc)
                .HasMaxLength(255)
                .HasColumnName("prodSeoDesc");
            entity.Property(e => e.ProdSeoKeys)
                .HasMaxLength(255)
                .HasColumnName("prodSeoKeys");
            entity.Property(e => e.ProdStockCode)
                .HasMaxLength(255)
                .HasColumnName("prodStockCode");
            entity.Property(e => e.ProdStockSize).HasColumnName("prodStockSize");
            entity.Property(e => e.ProdTavsiyePrice)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodTavsiyePrice");
            entity.Property(e => e.ProdVergiId).HasColumnName("prodVergiID");
            entity.Property(e => e.ProdVideoCatId).HasColumnName("prodVideoCatID");
            entity.Property(e => e.ProdVisitedCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("prodVisitedCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
            entity.Property(e => e.TGuncel).HasColumnName("tGuncel");
            entity.Property(e => e.TicketCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ticketCount");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<DbProductCategory>(entity =>
        {
            entity.HasKey(e => e.ProdCatId);

            entity.ToTable("dbProductCategories");

            entity.Property(e => e.ProdCatId).HasColumnName("prodCatID");
            entity.Property(e => e.CatId).HasColumnName("catID");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
        });

        modelBuilder.Entity<DbProductOption>(entity =>
        {
            entity.HasKey(e => e.ProdId);

            entity.ToTable("dbProductOptions");

            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdBarcodeNo)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeNo");
            entity.Property(e => e.ProdBirim).HasColumnName("prodBirim");
            entity.Property(e => e.ProdBirimDesc).HasColumnName("prodBirimDesc");
            entity.Property(e => e.ProdDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("prodDate");
            entity.Property(e => e.ProdIsActive).HasColumnName("prodIsActive");
            entity.Property(e => e.ProdName).HasColumnName("prodName");
            entity.Property(e => e.ProdParentId).HasColumnName("prodParentID");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.ProdSatisPrice).HasColumnName("prodSatisPrice");
            entity.Property(e => e.ProdStockSize).HasColumnName("prodStockSize");
            entity.Property(e => e.TGuncel).HasColumnName("tGuncel");
        });

        modelBuilder.Entity<DbQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId);

            entity.ToTable("dbQuestions");

            entity.Property(e => e.QuestionId).HasColumnName("questionID");
            entity.Property(e => e.QuestionDate)
                .HasMaxLength(50)
                .HasColumnName("questionDate");
            entity.Property(e => e.QuestionIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("questionIsActive");
            entity.Property(e => e.QuestionResponse).HasColumnName("questionResponse");
            entity.Property(e => e.QuestionText).HasColumnName("questionText");
            entity.Property(e => e.QuestionTitle)
                .HasMaxLength(255)
                .HasColumnName("questionTitle");
            entity.Property(e => e.QuestionUserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("questionUserID");
        });

        modelBuilder.Entity<DbRevizyonTakip>(entity =>
        {
            entity.HasKey(e => e.RevizyonId);

            entity.ToTable("dbRevizyonTakip");

            entity.Property(e => e.RevizyonId).HasColumnName("revizyonID");
            entity.Property(e => e.LogIp)
                .HasMaxLength(50)
                .HasColumnName("logIP");
            entity.Property(e => e.RevizyonAciklamasi).HasColumnName("revizyonAciklamasi");
            entity.Property(e => e.RevizyonBaslik)
                .HasMaxLength(255)
                .HasColumnName("revizyonBaslik");
            entity.Property(e => e.RevizyonKapatan).HasColumnName("revizyonKapatan");
            entity.Property(e => e.RevizyonKapatanNot).HasColumnName("revizyonKapatanNot");
            entity.Property(e => e.RevizyonPictureUrl)
                .HasMaxLength(50)
                .HasColumnName("revizyonPictureURL");
            entity.Property(e => e.RevizyonPictureUrl1)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("revizyonPictureURL1");
            entity.Property(e => e.RevizyonPictureUrl2)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("revizyonPictureURL2");
            entity.Property(e => e.RevizyonPictureUrl3)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("revizyonPictureURL3");
            entity.Property(e => e.RevizyonSonTarih)
                .HasColumnType("datetime")
                .HasColumnName("revizyonSonTarih");
            entity.Property(e => e.RevizyonTalepEden).HasColumnName("revizyonTalepEden");
            entity.Property(e => e.RevizyonTalepTarihi)
                .HasColumnType("datetime")
                .HasColumnName("revizyonTalepTarihi");
            entity.Property(e => e.RevizyonTipi).HasColumnName("revizyonTipi");
            entity.Property(e => e.RevizyonTuru)
                .HasMaxLength(255)
                .HasColumnName("revizyonTuru");
            entity.Property(e => e.RevizyonYapildiMi).HasColumnName("revizyonYapildiMi");
            entity.Property(e => e.Revizyononem).HasColumnName("revizyononem");
        });

        modelBuilder.Entity<DbRevizyonYorum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbRevizyonYorum");

            entity.Property(e => e.RevizyonId).HasColumnName("revizyonID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.Yorum).HasColumnName("yorum");
            entity.Property(e => e.YorumId).HasColumnName("yorumID");
            entity.Property(e => e.YorumTarih)
                .HasColumnType("datetime")
                .HasColumnName("yorumTarih");
        });

        modelBuilder.Entity<DbSetting>(entity =>
        {
            entity.HasKey(e => e.SettingsId);

            entity.ToTable("dbSettings");

            entity.Property(e => e.SettingsId).HasColumnName("settingsID");
            entity.Property(e => e.Admprl)
                .HasMaxLength(255)
                .HasColumnName("admprl");
            entity.Property(e => e.CariMustseri)
                .HasMaxLength(50)
                .HasColumnName("cariMustseri");
            entity.Property(e => e.CariTedseri)
                .HasMaxLength(50)
                .HasColumnName("cariTedseri");
            entity.Property(e => e.CariUserSeri)
                .HasMaxLength(50)
                .HasColumnName("cariUserSeri");
            entity.Property(e => e.Eksistokuyari).HasColumnName("eksistokuyari");
            entity.Property(e => e.Enfazlasatinalma).HasColumnName("enfazlasatinalma");
            entity.Property(e => e.FacebookUser)
                .HasMaxLength(255)
                .HasColumnName("facebookUser");
            entity.Property(e => e.Faturaseri)
                .HasMaxLength(255)
                .HasColumnName("faturaseri");
            entity.Property(e => e.FaxNumara)
                .HasMaxLength(255)
                .HasColumnName("faxNumara");
            entity.Property(e => e.Firmadokuman)
                .HasMaxLength(255)
                .HasColumnName("firmadokuman");
            entity.Property(e => e.Firmamudur1)
                .HasMaxLength(255)
                .HasColumnName("firmamudur1");
            entity.Property(e => e.Firmamudur2)
                .HasMaxLength(255)
                .HasColumnName("firmamudur2");
            entity.Property(e => e.Firmamuhasebe)
                .HasMaxLength(255)
                .HasColumnName("firmamuhasebe");
            entity.Property(e => e.Firmasgkno)
                .HasMaxLength(50)
                .HasColumnName("firmasgkno");
            entity.Property(e => e.Firmaticaretsicil)
                .HasMaxLength(50)
                .HasColumnName("firmaticaretsicil");
            entity.Property(e => e.Firmaunvan)
                .HasMaxLength(255)
                .HasColumnName("firmaunvan");
            entity.Property(e => e.Firmavergidairesi)
                .HasMaxLength(255)
                .HasColumnName("firmavergidairesi");
            entity.Property(e => e.Firmavergino)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("firmavergino");
            entity.Property(e => e.Fiyatkapat).HasColumnName("fiyatkapat");
            entity.Property(e => e.GoogleAnalitik)
                .HasMaxLength(50)
                .HasColumnName("googleAnalitik");
            entity.Property(e => e.GooglemapsX)
                .HasMaxLength(50)
                .HasColumnName("googlemapsX");
            entity.Property(e => e.GooglemapsY)
                .HasMaxLength(50)
                .HasColumnName("googlemapsY");
            entity.Property(e => e.GoogleplusUser)
                .HasMaxLength(255)
                .HasColumnName("googleplusUser");
            entity.Property(e => e.IkFormMail)
                .HasMaxLength(255)
                .HasColumnName("ikFormMail");
            entity.Property(e => e.InstagramUser).HasMaxLength(255);
            entity.Property(e => e.LinkedinUser).HasMaxLength(255);
            entity.Property(e => e.MagazaPostaAdresi)
                .HasMaxLength(255)
                .HasColumnName("magazaPostaAdresi");
            entity.Property(e => e.Musterihizmetleri)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("musterihizmetleri");
            entity.Property(e => e.PinterestUser).HasMaxLength(255);
            entity.Property(e => e.PrsetFreeShip).HasColumnName("prsetFreeShip");
            entity.Property(e => e.PrsetTransferDiscount).HasColumnName("prsetTransferDiscount");
            entity.Property(e => e.PrsetUpsprice).HasColumnName("prsetUPSPrice");
            entity.Property(e => e.Rsmyolu)
                .HasMaxLength(255)
                .HasColumnName("rsmyolu");
            entity.Property(e => e.Sanalpos).HasColumnName("sanalpos");
            entity.Property(e => e.SettingsCharset)
                .HasMaxLength(255)
                .HasColumnName("settingsCharset");
            entity.Property(e => e.SettingsDescription)
                .HasMaxLength(255)
                .HasColumnName("settingsDescription");
            entity.Property(e => e.SettingsKeywords)
                .HasMaxLength(255)
                .HasColumnName("settingsKeywords");
            entity.Property(e => e.SettingsMail)
                .HasMaxLength(255)
                .HasColumnName("settingsMail");
            entity.Property(e => e.SettingsPassword)
                .HasMaxLength(255)
                .HasColumnName("settingsPassword");
            entity.Property(e => e.SettingsPayProtocole)
                .HasMaxLength(255)
                .HasColumnName("settingsPayProtocole");
            entity.Property(e => e.SettingsRobots)
                .HasMaxLength(255)
                .HasColumnName("settingsRobots");
            entity.Property(e => e.SettingsSeoDesc)
                .HasMaxLength(255)
                .HasColumnName("settingsSeoDesc");
            entity.Property(e => e.SettingsSiteAuthor)
                .HasMaxLength(255)
                .HasColumnName("settingsSiteAuthor");
            entity.Property(e => e.SettingsSiteTitle)
                .HasMaxLength(255)
                .HasColumnName("settingsSiteTitle");
            entity.Property(e => e.SettingsSlogan)
                .HasMaxLength(255)
                .HasColumnName("settingsSlogan");
            entity.Property(e => e.SettingsSmtpPass)
                .HasMaxLength(255)
                .HasColumnName("settingsSmtpPass");
            entity.Property(e => e.SettingsSmtpPort)
                .HasMaxLength(255)
                .HasColumnName("settingsSmtpPort");
            entity.Property(e => e.SettingsSmtpServer)
                .HasMaxLength(255)
                .HasColumnName("settingsSmtpServer");
            entity.Property(e => e.SettingssiteIsActive).HasColumnName("settingssiteIsActive");
            entity.Property(e => e.Settingswebadres)
                .HasMaxLength(255)
                .HasColumnName("settingswebadres");
            entity.Property(e => e.Settingswebadres1)
                .HasMaxLength(255)
                .HasColumnName("settingswebadres1");
            entity.Property(e => e.Settingswebadres2)
                .HasMaxLength(255)
                .HasColumnName("settingswebadres2");
            entity.Property(e => e.SiteLangId).HasColumnName("siteLangID");
            entity.Property(e => e.SiteLogo)
                .HasMaxLength(255)
                .HasColumnName("siteLogo");
            entity.Property(e => e.Sitebakimda).HasColumnName("sitebakimda");
            entity.Property(e => e.Sitecopyright)
                .HasMaxLength(255)
                .HasColumnName("sitecopyright");
            entity.Property(e => e.SmsBayiKod).HasMaxLength(50);
            entity.Property(e => e.SmsFirma).HasMaxLength(50);
            entity.Property(e => e.SmsKullancisi).HasMaxLength(50);
            entity.Property(e => e.SmsParola).HasMaxLength(50);
            entity.Property(e => e.StajyerBasvuruMail)
                .HasMaxLength(255)
                .HasColumnName("stajyerBasvuruMail");
            entity.Property(e => e.Teknikservistel)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("teknikservistel");
            entity.Property(e => e.TelefonGsm)
                .HasMaxLength(255)
                .HasColumnName("telefonGsm");
            entity.Property(e => e.TelefonNumara1)
                .HasMaxLength(255)
                .HasColumnName("telefonNumara1");
            entity.Property(e => e.TelefonNumara2)
                .HasMaxLength(255)
                .HasColumnName("telefonNumara2");
            entity.Property(e => e.TwitterUser)
                .HasMaxLength(255)
                .HasColumnName("twitterUser");
            entity.Property(e => e.Verifikasyonkod)
                .HasMaxLength(255)
                .HasColumnName("verifikasyonkod");
            entity.Property(e => e.VimeoUser).HasMaxLength(255);
            entity.Property(e => e.WhatsappNo)
                .HasMaxLength(50)
                .HasColumnName("whatsappNo");
            entity.Property(e => e.YeniKayitMail)
                .HasMaxLength(255)
                .HasColumnName("yeniKayitMail");
            entity.Property(e => e.YoutubeUser).HasMaxLength(255);
        });

        modelBuilder.Entity<DbShiping>(entity =>
        {
            entity.HasKey(e => e.ShipId);

            entity.ToTable("dbShipings");

            entity.Property(e => e.ShipId).HasColumnName("shipID");
            entity.Property(e => e.KapidaOdemeContent).HasColumnName("kapidaOdemeContent");
            entity.Property(e => e.ShipDefault)
                .HasDefaultValueSql("((0))")
                .HasColumnName("shipDefault");
            entity.Property(e => e.ShipDesiAktif)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("shipDesiAktif");
            entity.Property(e => e.ShipDesiPrice)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("shipDesiPrice");
            entity.Property(e => e.ShipIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("shipIsActive");
            entity.Property(e => e.ShipKapiIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("shipKapiIsActive");
            entity.Property(e => e.ShipKapiPrice).HasColumnName("shipKapiPrice");
            entity.Property(e => e.ShipName)
                .HasMaxLength(255)
                .HasColumnName("shipName");
            entity.Property(e => e.ShipPrice).HasColumnName("shipPrice");
            entity.Property(e => e.ShipState)
                .HasMaxLength(255)
                .HasColumnName("shipState");
            entity.Property(e => e.ShipTuketiciFiyati).HasColumnName("shipTuketiciFiyati");
            entity.Property(e => e.ShipYetkiliName)
                .HasMaxLength(50)
                .HasColumnName("shipYetkiliName");
            entity.Property(e => e.Shiplinkkontrol)
                .HasMaxLength(255)
                .HasColumnName("shiplinkkontrol");
            entity.Property(e => e.Shipsube)
                .HasMaxLength(50)
                .HasColumnName("shipsube");
            entity.Property(e => e.Shiptelefon)
                .HasMaxLength(50)
                .HasColumnName("shiptelefon");
            entity.Property(e => e.TakipUrl)
                .HasMaxLength(255)
                .HasColumnName("takip_url");
        });

        modelBuilder.Entity<DbSikayetAdminNotlari>(entity =>
        {
            entity.HasKey(e => e.NotId);

            entity.ToTable("dbSikayetAdminNotlari");

            entity.Property(e => e.NotId).HasColumnName("not_id");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.EklenmeTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("eklenme_tarihi");
            entity.Property(e => e.Ekleyen)
                .HasMaxLength(70)
                .HasColumnName("ekleyen");
            entity.Property(e => e.SikayetId).HasColumnName("sikayet_id");
        });

        modelBuilder.Entity<DbSikayetIscilikleri>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("dbSikayetIscilikleri");

            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.IsAdmin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isAdmin");
            entity.Property(e => e.IscilikFiyat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("iscilikFiyat");
            entity.Property(e => e.IscilikId).HasColumnName("iscilikID");
            entity.Property(e => e.IscilikInputDeger)
                .HasMaxLength(255)
                .HasColumnName("iscilikInputDeger");
            entity.Property(e => e.LogAciklama).HasColumnName("logAciklama");
            entity.Property(e => e.LogAdminAciklama).HasColumnName("logAdminAciklama");
            entity.Property(e => e.LogDate)
                .HasColumnType("datetime")
                .HasColumnName("logDate");
            entity.Property(e => e.LogDegisiklik).HasColumnName("logDegisiklik");
            entity.Property(e => e.LogOnay).HasColumnName("logOnay");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.TamirTarihi)
                .HasColumnType("date")
                .HasColumnName("tamirTarihi");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<DbSikayetLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("dbSikayetLogs");

            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.LogDate)
                .HasMaxLength(255)
                .HasColumnName("logDate");
            entity.Property(e => e.LogDateTest)
                .HasColumnType("datetime")
                .HasColumnName("logDateTest");
            entity.Property(e => e.LogDescription).HasColumnName("logDescription");
            entity.Property(e => e.LogEskiAkuSerial)
                .HasMaxLength(255)
                .HasColumnName("logEskiAkuSerial");
            entity.Property(e => e.LogMalzemeler)
                .HasMaxLength(255)
                .HasColumnName("logMalzemeler");
            entity.Property(e => e.LogOkunduOnay).HasColumnName("logOkunduOnay");
            entity.Property(e => e.LogOkunduTarih)
                .HasColumnType("datetime")
                .HasColumnName("logOkunduTarih");
            entity.Property(e => e.LogRandevUser)
                .HasMaxLength(255)
                .HasColumnName("logRandevUser");
            entity.Property(e => e.LogRandevu)
                .HasColumnType("date")
                .HasColumnName("logRandevu");
            entity.Property(e => e.LogRandevuDescription).HasColumnName("logRandevuDescription");
            entity.Property(e => e.LogRandevuSaveUser)
                .HasMaxLength(255)
                .HasColumnName("logRandevuSaveUser");
            entity.Property(e => e.LogSikayetId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("logSikayetID");
            entity.Property(e => e.LogStateId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("logStateID");
            entity.Property(e => e.LogTalepDate)
                .HasMaxLength(255)
                .HasColumnName("logTalepDate");
            entity.Property(e => e.LogTalepOnayDate)
                .HasMaxLength(255)
                .HasColumnName("logTalepOnayDate");
            entity.Property(e => e.LogTalepOnayDescription).HasColumnName("logTalepOnayDescription");
            entity.Property(e => e.LogTalepOnayId)
                .HasMaxLength(255)
                .HasColumnName("logTalepOnayID");
            entity.Property(e => e.LogTalepOnayKm).HasColumnName("logTalepOnayKm");
            entity.Property(e => e.LogTalepOnayUserId)
                .HasMaxLength(255)
                .HasColumnName("logTalepOnayUserID");
            entity.Property(e => e.LogUserId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("logUserID");
            entity.Property(e => e.LogUserIsAdmin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("logUserIsAdmin");
            entity.Property(e => e.LogYeniAkuSerial)
                .HasMaxLength(255)
                .HasColumnName("logYeniAkuSerial");
            entity.Property(e => e.LogYolKm)
                .HasMaxLength(255)
                .HasColumnName("logYolKm");
            entity.Property(e => e.LogYolKmBedel).HasColumnName("logYolKmBedel");
            entity.Property(e => e.LogarizaId).HasColumnName("logarizaID");
            entity.Property(e => e.Logiptalsecenek).HasColumnName("logiptalsecenek");
            entity.Property(e => e.SikayetServisId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sikayetServisID");
        });

        modelBuilder.Entity<DbSikayetMesajlari>(entity =>
        {
            entity.HasKey(e => e.MesajId);

            entity.ToTable("dbSikayetMesajlari");

            entity.Property(e => e.MesajId).HasColumnName("mesajID");
            entity.Property(e => e.MesajBaslik)
                .HasMaxLength(255)
                .HasColumnName("mesajBaslik");
            entity.Property(e => e.MesajIcerik).HasColumnName("mesajIcerik");
            entity.Property(e => e.MesajKimdenId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mesajKimdenID");
            entity.Property(e => e.MesajKimeId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mesajKimeID");
            entity.Property(e => e.MesajOkunduIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mesajOkunduIsActive");
            entity.Property(e => e.MesajSikayetId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mesajSikayetID");
            entity.Property(e => e.MesajTarih)
                .HasColumnType("datetime")
                .HasColumnName("mesajTarih");
            entity.Property(e => e.MesajarizaId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("mesajarizaID");
        });

        modelBuilder.Entity<DbSikayetState>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("dbSikayetStates");

            entity.Property(e => e.StateId).HasColumnName("stateID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.StateDescription).HasColumnName("stateDescription");
            entity.Property(e => e.StateIsActive).HasColumnName("stateIsActive");
            entity.Property(e => e.StateName)
                .HasMaxLength(255)
                .HasColumnName("stateName");
            entity.Property(e => e.StatePrice).HasColumnName("statePrice");
            entity.Property(e => e.StateUrl)
                .HasMaxLength(255)
                .HasColumnName("stateURL");
        });

        modelBuilder.Entity<DbSikayetTipKat>(entity =>
        {
            entity.HasKey(e => e.BagId);

            entity.ToTable("dbSikayetTipKat");

            entity.Property(e => e.BagId).HasColumnName("bagID");
            entity.Property(e => e.ArizaCatId).HasColumnName("arizaCatID");
            entity.Property(e => e.ArizaId).HasColumnName("arizaID");
        });

        modelBuilder.Entity<DbSikayetTipleri>(entity =>
        {
            entity.HasKey(e => e.ArizaId);

            entity.ToTable("dbSikayetTipleri");

            entity.Property(e => e.ArizaId).HasColumnName("arizaID");
            entity.Property(e => e.ArizaAdi)
                .HasMaxLength(255)
                .HasColumnName("arizaAdi");
            entity.Property(e => e.ArizaDescription).HasColumnName("arizaDescription");
            entity.Property(e => e.ArizaKategoriId)
                .HasMaxLength(255)
                .HasColumnName("arizaKategoriID");
            entity.Property(e => e.ArizaKodu)
                .HasMaxLength(255)
                .HasColumnName("arizaKodu");
            entity.Property(e => e.ArizaPdf)
                .HasMaxLength(50)
                .HasColumnName("arizaPdf");
            entity.Property(e => e.ArizaSss)
                .HasMaxLength(255)
                .HasColumnName("arizaSSS");
            entity.Property(e => e.ArizaUrun)
                .HasMaxLength(255)
                .HasColumnName("arizaUrun");
            entity.Property(e => e.ArizaVideo).HasColumnName("arizaVideo");
        });

        modelBuilder.Entity<DbSikayetler>(entity =>
        {
            entity.HasKey(e => e.SikayetId);

            entity.ToTable("dbSikayetler");

            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.ErrorMessage).HasColumnName("errorMessage");
            entity.Property(e => e.HakedisDurum).HasColumnName("hakedisDurum");
            entity.Property(e => e.HakedisRedAciklama).HasColumnName("hakedisRedAciklama");
            entity.Property(e => e.PlsTelefonDegisti)
                .HasDefaultValueSql("((0))")
                .HasColumnName("plsTelefonDegisti");
            entity.Property(e => e.PlsTelefonGonderildi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("plsTelefonGonderildi");
            entity.Property(e => e.ServisFisNo)
                .HasMaxLength(255)
                .HasColumnName("servisFisNo");
            entity.Property(e => e.SikayetAltBayiId).HasColumnName("sikayetAltBayiID");
            entity.Property(e => e.SikayetAriza2Id).HasColumnName("sikayetAriza2ID");
            entity.Property(e => e.SikayetAriza3Id).HasColumnName("sikayetAriza3ID");
            entity.Property(e => e.SikayetArizaId).HasColumnName("sikayetArizaID");
            entity.Property(e => e.SikayetBayiId).HasColumnName("sikayetBayiID");
            entity.Property(e => e.SikayetCihazSahibi)
                .HasMaxLength(255)
                .HasColumnName("sikayetCihazSahibi");
            entity.Property(e => e.SikayetCihazSeri)
                .HasMaxLength(255)
                .HasColumnName("sikayetCihazSeri");
            entity.Property(e => e.SikayetDurum).HasColumnName("sikayetDurum");
            entity.Property(e => e.SikayetGarantiIsActive)
                .HasMaxLength(255)
                .HasColumnName("sikayetGarantiIsActive");
            entity.Property(e => e.SikayetGarantiNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetGarantiNo");
            entity.Property(e => e.SikayetGarantiNo1)
                .HasColumnType("date")
                .HasColumnName("sikayetGarantiNo1");
            entity.Property(e => e.SikayetHizmetTuru)
                .HasMaxLength(255)
                .HasColumnName("sikayetHizmetTuru");
            entity.Property(e => e.SikayetIcerik).HasColumnName("sikayetIcerik");
            entity.Property(e => e.SikayetIscilikTipi).HasColumnName("sikayetIscilikTipi");
            entity.Property(e => e.SikayetKategoriId).HasColumnName("sikayetKategoriID");
            entity.Property(e => e.SikayetKimActiId).HasColumnName("sikayetKimActiID");
            entity.Property(e => e.SikayetKimeAit)
                .HasMaxLength(255)
                .HasColumnName("sikayetKimeAit");
            entity.Property(e => e.SikayetMusteriAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriAdi");
            entity.Property(e => e.SikayetMusteriAdresi).HasColumnName("sikayetMusteriAdresi");
            entity.Property(e => e.SikayetMusteriCepTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriCepTelNo");
            entity.Property(e => e.SikayetMusteriIlceId).HasColumnName("sikayetMusteriIlceID");
            entity.Property(e => e.SikayetMusteriMail)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriMail");
            entity.Property(e => e.SikayetMusteriSehirId).HasColumnName("sikayetMusteriSehirID");
            entity.Property(e => e.SikayetMusteriSoyAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriSoyAdi");
            entity.Property(e => e.SikayetMusteriTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriTelNo");
            entity.Property(e => e.SikayetServisId).HasColumnName("sikayetServisID");
            entity.Property(e => e.SikayetSiparisId).HasColumnName("sikayetSiparisID");
            entity.Property(e => e.SikayetTarih)
                .HasColumnType("datetime")
                .HasColumnName("sikayetTarih");
            entity.Property(e => e.SikayetUrunId).HasColumnName("sikayetUrunID");
            entity.Property(e => e.SonGoruntuleme)
                .HasColumnType("datetime")
                .HasColumnName("sonGoruntuleme");
            entity.Property(e => e.TamirTarihi)
                .HasColumnType("date")
                .HasColumnName("tamirTarihi");
        });

        modelBuilder.Entity<DbSikayetlerGrouped>(entity =>
        {
            entity.ToTable("dbSikayetler_Grouped");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SikayetMusteriAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriAdi");
            entity.Property(e => e.SikayetMusteriCepTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriCepTelNo");
            entity.Property(e => e.SikayetMusteriSehirId).HasColumnName("sikayetMusteriSehirID");
            entity.Property(e => e.SikayetMusteriSoyAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriSoyAdi");
            entity.Property(e => e.SikayetMusteriTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriTelNo");
        });

        modelBuilder.Entity<DbSupplier>(entity =>
        {
            entity.HasKey(e => e.SuppliersId);

            entity.ToTable("dbSuppliers");

            entity.Property(e => e.SuppliersId).HasColumnName("suppliersID");
            entity.Property(e => e.SuppliersAddress).HasColumnName("suppliersAddress");
            entity.Property(e => e.SuppliersAuthor)
                .HasMaxLength(255)
                .HasColumnName("suppliersAuthor");
            entity.Property(e => e.SuppliersIsActive).HasColumnName("suppliersIsActive");
            entity.Property(e => e.SuppliersMail)
                .HasMaxLength(255)
                .HasColumnName("suppliersMail");
            entity.Property(e => e.SuppliersName)
                .HasMaxLength(255)
                .HasColumnName("suppliersName");
            entity.Property(e => e.SuppliersTelephone)
                .HasMaxLength(255)
                .HasColumnName("suppliersTelephone");
            entity.Property(e => e.SuppliersTelephone1)
                .HasMaxLength(50)
                .HasColumnName("suppliersTelephone1");
            entity.Property(e => e.Suppliersweb)
                .HasMaxLength(50)
                .HasColumnName("suppliersweb");
        });

        modelBuilder.Entity<DbTempCart>(entity =>
        {
            entity.HasKey(e => e.TempId);

            entity.ToTable("dbTempCart");

            entity.Property(e => e.TempId).HasColumnName("tempID");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.TempIsActive)
                .HasMaxLength(255)
                .HasColumnName("tempIsActive");
            entity.Property(e => e.TempOptId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("tempOptID");
            entity.Property(e => e.TempProductCount).HasColumnName("tempProductCount");
            entity.Property(e => e.TempProductId).HasColumnName("tempProductID");
            entity.Property(e => e.TempRandom).HasColumnName("tempRandom");
            entity.Property(e => e.TempSikayetId).HasColumnName("tempSikayetID");
            entity.Property(e => e.TempUserId).HasColumnName("tempUserID");
        });

        modelBuilder.Entity<DbTicket>(entity =>
        {
            entity.HasKey(e => e.Kimlik);

            entity.ToTable("dbTickets");
        });

        modelBuilder.Entity<DbTopluMailList>(entity =>
        {
            entity.HasKey(e => e.MailId).HasName("PK_dbTopluMailList1");

            entity.ToTable("dbTopluMailList");

            entity.Property(e => e.MailId).HasColumnName("mailID");
            entity.Property(e => e.AktifPasif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("aktifPasif");
            entity.Property(e => e.MailAdres)
                .HasMaxLength(255)
                .HasColumnName("mailAdres");
            entity.Property(e => e.MailKat).HasColumnName("mailKat");
        });

        modelBuilder.Entity<DbTopluMesaj>(entity =>
        {
            entity.HasKey(e => e.MesId);

            entity.ToTable("dbTopluMesaj");

            entity.Property(e => e.MesId).HasColumnName("mesID");
            entity.Property(e => e.MesKime)
                .HasMaxLength(255)
                .HasColumnName("mesKime");
            entity.Property(e => e.MesKonu)
                .HasMaxLength(255)
                .HasColumnName("mesKonu");
            entity.Property(e => e.MesMesaj).HasColumnName("mesMesaj");
            entity.Property(e => e.MesTarih)
                .HasColumnType("datetime")
                .HasColumnName("mesTarih");
        });

        modelBuilder.Entity<DbUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("dbUsers");

            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.BankId).HasColumnName("bankID");
            entity.Property(e => e.BasitUsul)
                .HasDefaultValueSql("((0))")
                .HasColumnName("basitUsul");
            entity.Property(e => e.FaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("faturaAdSoyad");
            entity.Property(e => e.FaturaCentId).HasColumnName("faturaCentID");
            entity.Property(e => e.FaturaContent).HasColumnName("faturaContent");
            entity.Property(e => e.FaturaDistrictId).HasColumnName("faturaDistrictID");
            entity.Property(e => e.FaturaTelNo)
                .HasMaxLength(11)
                .HasColumnName("faturaTelNo");
            entity.Property(e => e.HesapNo)
                .HasMaxLength(55)
                .HasColumnName("hesapNo");
            entity.Property(e => e.IbanNo)
                .HasMaxLength(255)
                .HasColumnName("ibanNo");
            entity.Property(e => e.IfsCariKodu)
                .HasMaxLength(50)
                .HasColumnName("ifs_cari_kodu");
            entity.Property(e => e.IfsSevkAdresi)
                .HasMaxLength(50)
                .HasColumnName("ifs_sevk_adresi");
            entity.Property(e => e.IsAdmin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isAdmin");
            entity.Property(e => e.Kisitlama)
                .HasDefaultValueSql("((0))")
                .HasColumnName("kisitlama");
            entity.Property(e => e.MusteriSiparisIzin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("musteri_siparis_izin");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.SubeAdi)
                .HasMaxLength(255)
                .HasColumnName("subeAdi");
            entity.Property(e => e.SubeKodu)
                .HasMaxLength(11)
                .HasColumnName("subeKodu");
            entity.Property(e => e.TeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("teslimatAdSoyad");
            entity.Property(e => e.TeslimatCentId).HasColumnName("teslimatCentID");
            entity.Property(e => e.TeslimatContent).HasColumnName("teslimatContent");
            entity.Property(e => e.TeslimatDistrictId).HasColumnName("teslimatDistrictID");
            entity.Property(e => e.TeslimatTelNo)
                .HasMaxLength(11)
                .HasColumnName("teslimatTelNo");
            entity.Property(e => e.UserBirthDate)
                .HasColumnType("datetime")
                .HasColumnName("userBirthDate");
            entity.Property(e => e.UserCariId)
                .HasMaxLength(55)
                .HasColumnName("userCariID");
            entity.Property(e => e.UserCentId).HasColumnName("userCentID");
            entity.Property(e => e.UserCustId)
                .HasMaxLength(255)
                .HasColumnName("userCustID");
            entity.Property(e => e.UserDistrictId).HasColumnName("userDistrictID");
            entity.Property(e => e.UserFirstLogin)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("userFirstLogin");
            entity.Property(e => e.UserGuid)
                .HasMaxLength(255)
                .HasColumnName("userGUID");
            entity.Property(e => e.UserIcerikYetki)
                .HasDefaultValueSql("((0))")
                .HasColumnName("userIcerikYetki");
            entity.Property(e => e.UserIp)
                .HasMaxLength(255)
                .HasColumnName("userIP");
            entity.Property(e => e.UserIsActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("userIsActive");
            entity.Property(e => e.UserKimlikNo)
                .HasMaxLength(11)
                .HasColumnName("userKimlikNo");
            entity.Property(e => e.UserLastLoginDate)
                .HasMaxLength(255)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("userLastLoginDate");
            entity.Property(e => e.UserMail)
                .HasMaxLength(255)
                .HasColumnName("userMail");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
            entity.Property(e => e.UserOnline)
                .HasDefaultValueSql("((0))")
                .HasColumnName("userOnline");
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .HasColumnName("userPass");
            entity.Property(e => e.UserPbeden)
                .HasMaxLength(255)
                .HasColumnName("userPBeden");
            entity.Property(e => e.UserPriceType).HasColumnName("userPriceType");
            entity.Property(e => e.UserSayfalar)
                .HasMaxLength(500)
                .HasColumnName("userSayfalar");
            entity.Property(e => e.UserSube)
                .HasDefaultValueSql("((0))")
                .HasColumnName("userSube");
            entity.Property(e => e.UserTalimatIsActive)
                .HasDefaultValueSql("((1))")
                .HasColumnName("userTalimatIsActive");
            entity.Property(e => e.UserTbeden)
                .HasMaxLength(255)
                .HasColumnName("userTBeden");
            entity.Property(e => e.UserTel1)
                .HasMaxLength(11)
                .HasColumnName("userTel1");
            entity.Property(e => e.UserTel2)
                .HasMaxLength(11)
                .HasColumnName("userTel2");
            entity.Property(e => e.UserTel3)
                .HasMaxLength(11)
                .HasColumnName("userTel3");
            entity.Property(e => e.UserTur)
                .HasDefaultValueSql("((0))")
                .HasColumnName("userTur");
            entity.Property(e => e.UserType).HasColumnName("userType");
            entity.Property(e => e.UserVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("userVergiDairesi");
            entity.Property(e => e.UserVergiNo)
                .HasMaxLength(10)
                .HasColumnName("userVergiNo");
            entity.Property(e => e.UserVideoYetki)
                .HasDefaultValueSql("((0))")
                .HasColumnName("userVideoYetki");
        });

        modelBuilder.Entity<DbUserEvent>(entity =>
        {
            entity.HasKey(e => e.Kimlik);

            entity.ToTable("dbUserEvents");
        });

        modelBuilder.Entity<DbVideo>(entity =>
        {
            entity.HasKey(e => e.RefId);

            entity.ToTable("dbVideos");

            entity.Property(e => e.RefId).HasColumnName("refID");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.RefDate)
                .HasMaxLength(50)
                .HasColumnName("refDate");
            entity.Property(e => e.RefDescription).HasColumnName("refDescription");
            entity.Property(e => e.RefIsActive).HasColumnName("refIsActive");
            entity.Property(e => e.RefLanguageId)
                .HasDefaultValueSql("((42))")
                .HasColumnName("refLanguageID");
            entity.Property(e => e.RefPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("refPictureURL");
            entity.Property(e => e.RefTitle)
                .HasMaxLength(255)
                .HasColumnName("refTitle");
            entity.Property(e => e.RefVideoUrl)
                .HasMaxLength(255)
                .HasColumnName("refVideoURL");
            entity.Property(e => e.RefVimeoId)
                .HasMaxLength(255)
                .HasColumnName("refVimeoID");
            entity.Property(e => e.RefYoutubeId)
                .HasMaxLength(255)
                .HasColumnName("refYoutubeID");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
        });

        modelBuilder.Entity<DbVideoCat>(entity =>
        {
            entity.HasKey(e => e.V1);

            entity.ToTable("dbVideoCats");

            entity.Property(e => e.V1).HasColumnName("v1");
            entity.Property(e => e.VideoCatId).HasColumnName("videoCatID");
            entity.Property(e => e.VideoId).HasColumnName("videoID");
        });

        modelBuilder.Entity<DbVideoCategory>(entity =>
        {
            entity.HasKey(e => e.VideoCatId);

            entity.ToTable("dbVideoCategories");

            entity.Property(e => e.VideoCatId).HasColumnName("videoCatID");
            entity.Property(e => e.PluralCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pluralCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount)
                .HasDefaultValueSql("((0))")
                .HasColumnName("singularCount");
            entity.Property(e => e.VideoCatContent).HasColumnName("videoCatContent");
            entity.Property(e => e.VideoCatDate)
                .HasColumnType("datetime")
                .HasColumnName("videoCatDate");
            entity.Property(e => e.VideoCatIsActive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("videoCatIsActive");
            entity.Property(e => e.VideoCatLanguageId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("videoCatLanguageID");
            entity.Property(e => e.VideoCatName)
                .HasMaxLength(250)
                .HasColumnName("videoCatName");
            entity.Property(e => e.VideoCatOrderCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("videoCatOrderCount");
            entity.Property(e => e.VideoCatParentCategoryId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("videoCatParentCategoryID");
            entity.Property(e => e.VideoCatPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("videoCatPictureURL");
        });

        modelBuilder.Entity<DbYedekParcalar>(entity =>
        {
            entity.ToTable("dbYedekParcalar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("aciklama");
            entity.Property(e => e.BirimFiyat).HasColumnName("birim_fiyat");
            entity.Property(e => e.DonemId).HasColumnName("donemID");
            entity.Property(e => e.DonemTarih)
                .HasColumnType("date")
                .HasColumnName("donemTarih");
            entity.Property(e => e.DonemUserId).HasColumnName("donemUserID");
            entity.Property(e => e.Miktar).HasColumnName("miktar");
            entity.Property(e => e.ProdNo)
                .HasMaxLength(255)
                .HasColumnName("prodNo");
        });

        modelBuilder.Entity<DbcariHesaplar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbcariHesaplar");

            entity.Property(e => e.BelgeTuru).HasMaxLength(50);
            entity.Property(e => e.CariNo).HasMaxLength(50);
            entity.Property(e => e.DokumanNo).HasMaxLength(50);
            entity.Property(e => e.EklenmeTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.TGuncel).HasColumnName("tGuncel");
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<Dbiletisim>(entity =>
        {
            entity.HasKey(e => e.IltId);

            entity.ToTable("dbiletisim");

            entity.Property(e => e.IltId).HasColumnName("iltID");
            entity.Property(e => e.Adsoyad)
                .HasMaxLength(255)
                .HasColumnName("adsoyad");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.IltIsActive).HasColumnName("iltIsActive");
            entity.Property(e => e.IltKonu)
                .HasMaxLength(255)
                .HasColumnName("iltKonu");
            entity.Property(e => e.IltTur)
                .HasMaxLength(255)
                .HasColumnName("iltTur");
            entity.Property(e => e.Iltdate)
                .HasColumnType("datetime")
                .HasColumnName("iltdate");
            entity.Property(e => e.Mesaj).HasColumnName("mesaj");
            entity.Property(e => e.MesajCevap).HasColumnName("mesajCevap");
            entity.Property(e => e.MesajDurum).HasColumnName("mesajDurum");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .HasColumnName("telefon");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserlogIp)
                .HasMaxLength(255)
                .HasColumnName("userlogIP");
        });

        modelBuilder.Entity<Dbiller>(entity =>
        {
            entity.HasKey(e => e.SehirD);

            entity.ToTable("dbiller");

            entity.Property(e => e.SehirD).HasColumnName("sehirD");
            entity.Property(e => e.SehirName)
                .HasMaxLength(255)
                .HasColumnName("sehirName");
        });

        modelBuilder.Entity<IfsCari>(entity =>
        {
            entity.ToTable("IFS_cari");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BelgeTuru)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CariNo).HasMaxLength(50);
            entity.Property(e => e.DokumanNo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tarih).HasColumnType("date");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<OnlineMesaj>(entity =>
        {
            entity.HasKey(e => e.MesajId);

            entity.ToTable("onlineMesaj");

            entity.Property(e => e.MesajId).HasColumnName("mesajID");
            entity.Property(e => e.MesajBaslik)
                .HasMaxLength(255)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("mesajBaslik");
            entity.Property(e => e.MesajIcerik)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("mesajIcerik");
            entity.Property(e => e.MesajKimdenId).HasColumnName("mesajKimdenID");
            entity.Property(e => e.MesajOkunduIsActive).HasColumnName("mesajOkunduIsActive");
            entity.Property(e => e.MesajParentId).HasColumnName("mesajParentID");
            entity.Property(e => e.MesajTarih)
                .HasColumnType("datetime")
                .HasColumnName("mesajTarih");
            entity.Property(e => e.MesajUserId).HasColumnName("mesajUserID");
        });

        modelBuilder.Entity<PilsanCustLedgerEntry437dbf0e84ff417a965dEd2bb9650972>(entity =>
        {
            entity.HasKey(e => e.EntryNo).HasName("Pilsan$Cust_ Ledger Entry$437dbf0e-84ff-417a-965d-ed2bb9650972$Key1");

            entity.ToTable("Pilsan$Cust_ Ledger Entry$437dbf0e-84ff-417a-965d-ed2bb9650972");

            entity.HasIndex(e => e.SystemId, "Pilsan$Cust_ Ledger Entry$437dbf0e-84ff-417a-965d-ed2bb9650972$$systemId").IsUnique();

            entity.Property(e => e.EntryNo)
                .ValueGeneratedNever()
                .HasColumnName("Entry No_");
            entity.Property(e => e.AcceptedPaymentTolerance)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Accepted Payment Tolerance");
            entity.Property(e => e.AcceptedPmtDiscTolerance).HasColumnName("Accepted Pmt_ Disc_ Tolerance");
            entity.Property(e => e.AdjustedCurrencyFactor)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Adjusted Currency Factor");
            entity.Property(e => e.AmountToApply)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Amount to Apply");
            entity.Property(e => e.AppliesToDocNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Applies-to Doc_ No_");
            entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");
            entity.Property(e => e.AppliesToExtDocNo)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Applies-to Ext_ Doc_ No_");
            entity.Property(e => e.AppliesToId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Applies-to ID");
            entity.Property(e => e.ApplyingEntry).HasColumnName("Applying Entry");
            entity.Property(e => e.BalAccountNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bal_ Account No_");
            entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");
            entity.Property(e => e.CalculateInterest).HasColumnName("Calculate Interest");
            entity.Property(e => e.ClosedAtDate)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Closed at Date");
            entity.Property(e => e.ClosedByAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Closed by Amount");
            entity.Property(e => e.ClosedByAmountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Closed by Amount (LCY)");
            entity.Property(e => e.ClosedByCurrencyAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Closed by Currency Amount");
            entity.Property(e => e.ClosedByCurrencyCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Closed by Currency Code");
            entity.Property(e => e.ClosedByEntryNo).HasColumnName("Closed by Entry No_");
            entity.Property(e => e.ClosingInterestCalculated).HasColumnName("Closing Interest Calculated");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Currency Code");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Customer Name");
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Customer No_");
            entity.Property(e => e.CustomerPostingGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Customer Posting Group");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");
            entity.Property(e => e.DirectDebitMandateId)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Direct Debit Mandate ID");
            entity.Property(e => e.DocumentDate)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Document Date");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Document No_");
            entity.Property(e => e.DocumentType).HasColumnName("Document Type");
            entity.Property(e => e.DueDate)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Due Date");
            entity.Property(e => e.ExportedToPaymentFile).HasColumnName("Exported to Payment File");
            entity.Property(e => e.ExternalDocumentNo)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("External Document No_");
            entity.Property(e => e.GlobalDimension1Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Global Dimension 1 Code");
            entity.Property(e => e.GlobalDimension2Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Global Dimension 2 Code");
            entity.Property(e => e.IcPartnerCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("IC Partner Code");
            entity.Property(e => e.InvDiscountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Inv_ Discount (LCY)");
            entity.Property(e => e.JournalBatchName)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Journal Batch Name");
            entity.Property(e => e.LastIssuedReminderLevel).HasColumnName("Last Issued Reminder Level");
            entity.Property(e => e.MaxPaymentTolerance)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Max_ Payment Tolerance");
            entity.Property(e => e.MessageToRecipient)
                .HasMaxLength(140)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Message to Recipient");
            entity.Property(e => e.NoSeries)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("No_ Series");
            entity.Property(e => e.OnHold)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("On Hold");
            entity.Property(e => e.OriginalCurrencyFactor)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Original Currency Factor");
            entity.Property(e => e.OriginalPmtDiscPossible)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Original Pmt_ Disc_ Possible");
            entity.Property(e => e.PaymentMethodCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Payment Method Code");
            entity.Property(e => e.PaymentReference)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Payment Reference");
            entity.Property(e => e.PmtDiscGivenLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Pmt_ Disc_ Given (LCY)");
            entity.Property(e => e.PmtDiscToleranceDate)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Pmt_ Disc_ Tolerance Date");
            entity.Property(e => e.PmtDiscountDate)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Pmt_ Discount Date");
            entity.Property(e => e.PmtToleranceLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Pmt_ Tolerance (LCY)");
            entity.Property(e => e.PostingDate)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Posting Date");
            entity.Property(e => e.ProfitLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Profit (LCY)");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Reason Code");
            entity.Property(e => e.RecipientBankAccount)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Recipient Bank Account");
            entity.Property(e => e.RemainingPmtDiscPossible)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Remaining Pmt_ Disc_ Possible");
            entity.Property(e => e.ReversedByEntryNo).HasColumnName("Reversed by Entry No_");
            entity.Property(e => e.ReversedEntryNo).HasColumnName("Reversed Entry No_");
            entity.Property(e => e.SalesLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Sales (LCY)");
            entity.Property(e => e.SalespersonCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Salesperson Code");
            entity.Property(e => e.SellToCustomerNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Sell-to Customer No_");
            entity.Property(e => e.SourceCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Source Code");
            entity.Property(e => e.SystemCreatedAt)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("$systemCreatedAt");
            entity.Property(e => e.SystemCreatedBy).HasColumnName("$systemCreatedBy");
            entity.Property(e => e.SystemId)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("$systemId");
            entity.Property(e => e.SystemModifiedAt)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("$systemModifiedAt");
            entity.Property(e => e.SystemModifiedBy).HasColumnName("$systemModifiedBy");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timestamp");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("User ID");
        });

        modelBuilder.Entity<PilsanCustomer437dbf0e84ff417a965dEd2bb9650972>(entity =>
        {
            entity.HasKey(e => e.No).HasName("Pilsan$Customer$437dbf0e-84ff-417a-965d-ed2bb9650972$Key1");

            entity.ToTable("Pilsan$Customer$437dbf0e-84ff-417a-965d-ed2bb9650972");

            entity.HasIndex(e => e.SystemId, "Pilsan$Customer$437dbf0e-84ff-417a-965d-ed2bb9650972$$systemId").IsUnique();

            entity.Property(e => e.No)
                .HasMaxLength(20)
                .HasColumnName("No_");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Address 2");
            entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");
            entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ApplicationMethod).HasColumnName("Application Method");
            entity.Property(e => e.BaseCalendarCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Base Calendar Code");
            entity.Property(e => e.BillToCustomerNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bill-to Customer No_");
            entity.Property(e => e.BlockPaymentTolerance).HasColumnName("Block Payment Tolerance");
            entity.Property(e => e.BudgetedAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Budgeted Amount");
            entity.Property(e => e.CashFlowPaymentTermsCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Cash Flow Payment Terms Code");
            entity.Property(e => e.ChainName)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Chain Name");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CollectionMethod)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Collection Method");
            entity.Property(e => e.CombineShipments).HasColumnName("Combine Shipments");
            entity.Property(e => e.Contact)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ContactGraphId)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Contact Graph Id");
            entity.Property(e => e.ContactId).HasColumnName("Contact ID");
            entity.Property(e => e.ContactType).HasColumnName("Contact Type");
            entity.Property(e => e.CopySellToAddrToQteFrom).HasColumnName("Copy Sell-to Addr_ to Qte From");
            entity.Property(e => e.CountryRegionCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Country_Region Code");
            entity.Property(e => e.County)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CreditLimitLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Credit Limit (LCY)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Currency Code");
            entity.Property(e => e.CurrencyId).HasColumnName("Currency Id");
            entity.Property(e => e.CustomerDiscGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Customer Disc_ Group");
            entity.Property(e => e.CustomerPostingGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Customer Posting Group");
            entity.Property(e => e.CustomerPriceGroup)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Customer Price Group");
            entity.Property(e => e.DisableSearchByName).HasColumnName("Disable Search by Name");
            entity.Property(e => e.DocumentSendingProfile)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Document Sending Profile");
            entity.Property(e => e.EMail)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("E-Mail");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Fax No_");
            entity.Property(e => e.FinChargeTermsCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Fin_ Charge Terms Code");
            entity.Property(e => e.GenBusPostingGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Gen_ Bus_ Posting Group");
            entity.Property(e => e.Gln)
                .HasMaxLength(13)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("GLN");
            entity.Property(e => e.GlobalDimension1Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Global Dimension 1 Code");
            entity.Property(e => e.GlobalDimension2Code)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Global Dimension 2 Code");
            entity.Property(e => e.HomePage)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Home Page");
            entity.Property(e => e.IcPartnerCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("IC Partner Code");
            entity.Property(e => e.InvoiceCopies).HasColumnName("Invoice Copies");
            entity.Property(e => e.InvoiceDiscCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Invoice Disc_ Code");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Language Code");
            entity.Property(e => e.LastDateModified)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Last Date Modified");
            entity.Property(e => e.LastModifiedDateTime)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Last Modified Date Time");
            entity.Property(e => e.LastStatementNo).HasColumnName("Last Statement No_");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Location Code");
            entity.Property(e => e.MobilePhoneNo)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Mobile Phone No_");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Name2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Name 2");
            entity.Property(e => e.NoSeries)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("No_ Series");
            entity.Property(e => e.OurAccountNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Our Account No_");
            entity.Property(e => e.PartnerType).HasColumnName("Partner Type");
            entity.Property(e => e.PaymentMethodCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Payment Method Code");
            entity.Property(e => e.PaymentMethodId).HasColumnName("Payment Method Id");
            entity.Property(e => e.PaymentTermsCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Payment Terms Code");
            entity.Property(e => e.PaymentTermsId).HasColumnName("Payment Terms Id");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Phone No_");
            entity.Property(e => e.Picture).HasColumnType("image");
            entity.Property(e => e.PlaceOfExport)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Place of Export");
            entity.Property(e => e.PostCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Post Code");
            entity.Property(e => e.PreferredBankAccountCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Preferred Bank Account Code");
            entity.Property(e => e.Prepayment)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Prepayment _");
            entity.Property(e => e.PriceCalculationMethod).HasColumnName("Price Calculation Method");
            entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");
            entity.Property(e => e.PrimaryContactNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Primary Contact No_");
            entity.Property(e => e.PrintStatements).HasColumnName("Print Statements");
            entity.Property(e => e.PrivacyBlocked).HasColumnName("Privacy Blocked");
            entity.Property(e => e.ReminderTermsCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Reminder Terms Code");
            entity.Property(e => e.ResponsibilityCenter)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Responsibility Center");
            entity.Property(e => e.SalespersonCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Salesperson Code");
            entity.Property(e => e.SearchName)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Search Name");
            entity.Property(e => e.ServiceZoneCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Service Zone Code");
            entity.Property(e => e.ShipToCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Ship-to Code");
            entity.Property(e => e.ShipmentMethodCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Shipment Method Code");
            entity.Property(e => e.ShipmentMethodId).HasColumnName("Shipment Method Id");
            entity.Property(e => e.ShippingAdvice).HasColumnName("Shipping Advice");
            entity.Property(e => e.ShippingAgentCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Shipping Agent Code");
            entity.Property(e => e.ShippingAgentServiceCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Shipping Agent Service Code");
            entity.Property(e => e.ShippingTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("Shipping Time");
            entity.Property(e => e.StatisticsGroup).HasColumnName("Statistics Group");
            entity.Property(e => e.SystemCreatedAt)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("$systemCreatedAt");
            entity.Property(e => e.SystemCreatedBy).HasColumnName("$systemCreatedBy");
            entity.Property(e => e.SystemId)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("$systemId");
            entity.Property(e => e.SystemModifiedAt)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("$systemModifiedAt");
            entity.Property(e => e.SystemModifiedBy).HasColumnName("$systemModifiedBy");
            entity.Property(e => e.TaxAreaCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Tax Area Code");
            entity.Property(e => e.TaxAreaId).HasColumnName("Tax Area ID");
            entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");
            entity.Property(e => e.TelexAnswerBack)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Telex Answer Back");
            entity.Property(e => e.TelexNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Telex No_");
            entity.Property(e => e.TerritoryCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Territory Code");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timestamp");
            entity.Property(e => e.UseGlnInElectronicDocument).HasColumnName("Use GLN in Electronic Document");
            entity.Property(e => e.ValidateEuVatRegNo).HasColumnName("Validate EU Vat Reg_ No_");
            entity.Property(e => e.VatBusPostingGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("VAT Bus_ Posting Group");
            entity.Property(e => e.VatRegistrationNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("VAT Registration No_");
        });

        modelBuilder.Entity<PilsanDetailedCustLedgEntry437dbf0e84ff417a965dEd2bb9650972>(entity =>
        {
            entity.HasKey(e => e.EntryNo).HasName("Pilsan$Detailed Cust_ Ledg_ Entry$437dbf0e-84ff-417a-965d-ed2bb9650972$Key1");

            entity.ToTable("Pilsan$Detailed Cust_ Ledg_ Entry$437dbf0e-84ff-417a-965d-ed2bb9650972");

            entity.HasIndex(e => e.SystemId, "Pilsan$Detailed Cust_ Ledg_ Entry$437dbf0e-84ff-417a-965d-ed2bb9650972$$systemId").IsUnique();

            entity.Property(e => e.EntryNo)
                .ValueGeneratedNever()
                .HasColumnName("Entry No_");
            entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.AmountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Amount (LCY)");
            entity.Property(e => e.ApplicationNo).HasColumnName("Application No_");
            entity.Property(e => e.AppliedCustLedgerEntryNo).HasColumnName("Applied Cust_ Ledger Entry No_");
            entity.Property(e => e.CreditAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Credit Amount");
            entity.Property(e => e.CreditAmountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Credit Amount (LCY)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Currency Code");
            entity.Property(e => e.CustLedgerEntryNo).HasColumnName("Cust_ Ledger Entry No_");
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Customer No_");
            entity.Property(e => e.DebitAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Debit Amount");
            entity.Property(e => e.DebitAmountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Debit Amount (LCY)");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Document No_");
            entity.Property(e => e.DocumentType).HasColumnName("Document Type");
            entity.Property(e => e.EntryType).HasColumnName("Entry Type");
            entity.Property(e => e.GenBusPostingGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Gen_ Bus_ Posting Group");
            entity.Property(e => e.GenProdPostingGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Gen_ Prod_ Posting Group");
            entity.Property(e => e.InitialDocumentType).HasColumnName("Initial Document Type");
            entity.Property(e => e.InitialEntryDueDate)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Initial Entry Due Date");
            entity.Property(e => e.InitialEntryGlobalDim1)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Initial Entry Global Dim_ 1");
            entity.Property(e => e.InitialEntryGlobalDim2)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Initial Entry Global Dim_ 2");
            entity.Property(e => e.JournalBatchName)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Journal Batch Name");
            entity.Property(e => e.LedgerEntryAmount).HasColumnName("Ledger Entry Amount");
            entity.Property(e => e.MaxPaymentTolerance)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Max_ Payment Tolerance");
            entity.Property(e => e.PostingDate)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("Posting Date");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Reason Code");
            entity.Property(e => e.RemainingPmtDiscPossible)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Remaining Pmt_ Disc_ Possible");
            entity.Property(e => e.SourceCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Source Code");
            entity.Property(e => e.SystemCreatedAt)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("$systemCreatedAt");
            entity.Property(e => e.SystemCreatedBy).HasColumnName("$systemCreatedBy");
            entity.Property(e => e.SystemId)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("$systemId");
            entity.Property(e => e.SystemModifiedAt)
                .HasDefaultValueSql("('1753.01.01')")
                .HasColumnType("datetime")
                .HasColumnName("$systemModifiedAt");
            entity.Property(e => e.SystemModifiedBy).HasColumnName("$systemModifiedBy");
            entity.Property(e => e.TaxJurisdictionCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Tax Jurisdiction Code");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timestamp");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");
            entity.Property(e => e.UnappliedByEntryNo).HasColumnName("Unapplied by Entry No_");
            entity.Property(e => e.UseTax).HasColumnName("Use Tax");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("User ID");
            entity.Property(e => e.VatBusPostingGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("VAT Bus_ Posting Group");
            entity.Property(e => e.VatProdPostingGroup)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("VAT Prod_ Posting Group");
        });

        modelBuilder.Entity<PilsanPlastikSanVeTicAŞCustLedgerEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pilsan Plastik San_ve Tic_A_Ş_$Cust_ Ledger Entry");

            entity.Property(e => e.AcceptedPaymentTolerance)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Accepted Payment Tolerance");
            entity.Property(e => e.AcceptedPmtDiscTolerance).HasColumnName("Accepted Pmt_ Disc_ Tolerance");
            entity.Property(e => e.AdjustedCurrencyFactor)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Adjusted Currency Factor");
            entity.Property(e => e.AmountToApply)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Amount to Apply");
            entity.Property(e => e.AppliesToDocNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Applies-to Doc_ No_");
            entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");
            entity.Property(e => e.AppliesToId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Applies-to ID");
            entity.Property(e => e.ApplyingEntry).HasColumnName("Applying Entry");
            entity.Property(e => e.BalAccountNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Bal_ Account No_");
            entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");
            entity.Property(e => e.CalculateInterest).HasColumnName("Calculate Interest");
            entity.Property(e => e.CancelledInvDocNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cancelled Inv_ Doc_ No");
            entity.Property(e => e.ClosedAtDate)
                .HasColumnType("datetime")
                .HasColumnName("Closed at Date");
            entity.Property(e => e.ClosedByAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Closed by Amount");
            entity.Property(e => e.ClosedByAmountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Closed by Amount (LCY)");
            entity.Property(e => e.ClosedByCurrencyAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Closed by Currency Amount");
            entity.Property(e => e.ClosedByCurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Closed by Currency Code");
            entity.Property(e => e.ClosedByEntryNo).HasColumnName("Closed by Entry No_");
            entity.Property(e => e.ClosingInterestCalculated).HasColumnName("Closing Interest Calculated");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Currency Code");
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Customer No_");
            entity.Property(e => e.CustomerPostingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Customer Posting Group");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentDate)
                .HasColumnType("datetime")
                .HasColumnName("Document Date");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Document No_");
            entity.Property(e => e.DocumentType).HasColumnName("Document Type");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("Due Date");
            entity.Property(e => e.EntryNo).HasColumnName("Entry No_");
            entity.Property(e => e.EntryStatus).HasColumnName("Entry Status");
            entity.Property(e => e.ExternalDocumentNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("External Document No_");
            entity.Property(e => e.GlobalDimension1Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Global Dimension 1 Code");
            entity.Property(e => e.GlobalDimension2Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Global Dimension 2 Code");
            entity.Property(e => e.IcPartnerCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IC Partner Code");
            entity.Property(e => e.IntouchDate)
                .HasColumnType("datetime")
                .HasColumnName("Intouch Date");
            entity.Property(e => e.InvDiscountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Inv_ Discount (LCY)");
            entity.Property(e => e.JournalBatchName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Journal Batch Name");
            entity.Property(e => e.LastIssuedReminderLevel).HasColumnName("Last Issued Reminder Level");
            entity.Property(e => e.MaxPaymentTolerance)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Max_ Payment Tolerance");
            entity.Property(e => e.NoSeries)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("No_ Series");
            entity.Property(e => e.OnHold)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("On Hold");
            entity.Property(e => e.OriginalCurrencyFactor)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Original Currency Factor");
            entity.Property(e => e.OriginalPmtDiscPossible)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Original Pmt_ Disc_ Possible");
            entity.Property(e => e.PmtDiscGivenLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Pmt_ Disc_ Given (LCY)");
            entity.Property(e => e.PmtDiscToleranceDate)
                .HasColumnType("datetime")
                .HasColumnName("Pmt_ Disc_ Tolerance Date");
            entity.Property(e => e.PmtDiscountDate)
                .HasColumnType("datetime")
                .HasColumnName("Pmt_ Discount Date");
            entity.Property(e => e.PmtToleranceLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Pmt_ Tolerance (LCY)");
            entity.Property(e => e.PostingDate)
                .HasColumnType("datetime")
                .HasColumnName("Posting Date");
            entity.Property(e => e.ProfitLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Profit (LCY)");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Reason Code");
            entity.Property(e => e.RemainingPmtDiscPossible)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Remaining Pmt_ Disc_ Possible");
            entity.Property(e => e.ReversedByEntryNo).HasColumnName("Reversed by Entry No_");
            entity.Property(e => e.ReversedEntryNo).HasColumnName("Reversed Entry No_");
            entity.Property(e => e.SalesLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Sales (LCY)");
            entity.Property(e => e.SalespersonCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Salesperson Code");
            entity.Property(e => e.SellToCustomerNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Sell-to Customer No_");
            entity.Property(e => e.SourceCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Source Code");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timestamp");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User ID");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Voucher No");
        });

        modelBuilder.Entity<PilsanPlastikSanVeTicAŞCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pilsan Plastik San_ve Tic_A_Ş_$Customer");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Address 2");
            entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");
            entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ApplicationMethod).HasColumnName("Application Method");
            entity.Property(e => e.AvgChequeDueDate)
                .HasColumnType("datetime")
                .HasColumnName("Avg_ Cheque Due Date");
            entity.Property(e => e.BankruptCompany).HasColumnName("Bankrupt company");
            entity.Property(e => e.BarcodeTemplate)
                .HasColumnType("image")
                .HasColumnName("Barcode Template");
            entity.Property(e => e.BaseCalendarCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Base Calendar Code");
            entity.Property(e => e.BillToCustomerNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Bill-to Customer No_");
            entity.Property(e => e.BlockPaymentTolerance).HasColumnName("Block Payment Tolerance");
            entity.Property(e => e.BudgetedAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Budgeted Amount");
            entity.Property(e => e.ChainName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Chain Name");
            entity.Property(e => e.ChequeRiskLimit)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Cheque Risk Limit");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CollectionMethod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Collection Method");
            entity.Property(e => e.CombineShipments).HasColumnName("Combine Shipments");
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CopySellToAddrToQteFrom).HasColumnName("Copy Sell-to Addr_ to Qte From");
            entity.Property(e => e.CountryRegionCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Country_Region Code");
            entity.Property(e => e.County)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreditLimitLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Credit Limit (LCY)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Currency Code");
            entity.Property(e => e.CustomerDiscGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Customer Disc_ Group");
            entity.Property(e => e.CustomerPostingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Customer Posting Group");
            entity.Property(e => e.CustomerPriceGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Customer Price Group");
            entity.Property(e => e.Discount1)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Discount 1");
            entity.Property(e => e.Discount2)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Discount 2");
            entity.Property(e => e.Discount3)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Discount 3");
            entity.Property(e => e.EArchieveDeliveryMethod).HasColumnName("E-Archieve Delivery Method");
            entity.Property(e => e.EInvoiceBarcodePrint).HasColumnName("e-Invoice Barcode Print");
            entity.Property(e => e.EInvoiceTemplateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("e-Invoice Template ID");
            entity.Property(e => e.EMail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("E-Mail");
            entity.Property(e => e.EMail2)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("E-Mail2");
            entity.Property(e => e.ExchNoteRiskControl).HasColumnName("Exch_ Note Risk Control");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Fax No_");
            entity.Property(e => e.FinChargeTermsCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Fin_ Charge Terms Code");
            entity.Property(e => e.GenBusPostingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Gen_ Bus_ Posting Group");
            entity.Property(e => e.GibRegisteredTaxNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("GIB Registered Tax No_");
            entity.Property(e => e.GlobalDimension1Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Global Dimension 1 Code");
            entity.Property(e => e.GlobalDimension2Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Global Dimension 2 Code");
            entity.Property(e => e.HomePage)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("Home Page");
            entity.Property(e => e.IcPartnerCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IC Partner Code");
            entity.Property(e => e.IncludeInErcInv).HasColumnName("Include in ERC Inv_");
            entity.Property(e => e.InvoiceCopies).HasColumnName("Invoice Copies");
            entity.Property(e => e.InvoiceDiscCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Invoice Disc_ Code");
            entity.Property(e => e.InvoicingType).HasColumnName("Invoicing Type");
            entity.Property(e => e.LanguageCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Language Code");
            entity.Property(e => e.LastDateModified)
                .HasColumnType("datetime")
                .HasColumnName("Last Date Modified");
            entity.Property(e => e.LastStatementNo).HasColumnName("Last Statement No_");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Location Code");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Name 2");
            entity.Property(e => e.NewItem).HasColumnName("New Item");
            entity.Property(e => e.No)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("No_");
            entity.Property(e => e.NoSeries)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("No_ Series");
            entity.Property(e => e.OurAccountNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Our Account No_");
            entity.Property(e => e.PaymentMethodCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Payment Method Code");
            entity.Property(e => e.PaymentTermsCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Payment Terms Code");
            entity.Property(e => e.PersonalIdentityNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Personal Identity No_");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Phone No_");
            entity.Property(e => e.Picture).HasColumnType("image");
            entity.Property(e => e.PlaceOfExport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Place of Export");
            entity.Property(e => e.PostCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Post Code");
            entity.Property(e => e.Prepayment)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Prepayment %");
            entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");
            entity.Property(e => e.PrimaryContactNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Primary Contact No_");
            entity.Property(e => e.PrintStatements).HasColumnName("Print Statements");
            entity.Property(e => e.PromNoteLimit)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Prom_ Note Limit");
            entity.Property(e => e.ReminderTermsCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Reminder Terms Code");
            entity.Property(e => e.ResponsibilityCenter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Responsibility Center");
            entity.Property(e => e.SalespersonCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Salesperson Code");
            entity.Property(e => e.SearchName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Search Name");
            entity.Property(e => e.SegmentCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Segment Code");
            entity.Property(e => e.SendShipmentViaMail).HasColumnName("Send Shipment Via Mail");
            entity.Property(e => e.ServiceDiscountPerct)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Service Discount Perct");
            entity.Property(e => e.ServiceZoneCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Service Zone Code");
            entity.Property(e => e.ShipmentMethodCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Shipment Method Code");
            entity.Property(e => e.ShippingAdvice).HasColumnName("Shipping Advice");
            entity.Property(e => e.ShippingAgentCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Shipping Agent Code");
            entity.Property(e => e.ShippingAgentServiceCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Shipping Agent Service Code");
            entity.Property(e => e.ShippingTime)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Shipping Time");
            entity.Property(e => e.StatisticsGroup).HasColumnName("Statistics Group");
            entity.Property(e => e.StoreCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Store Code");
            entity.Property(e => e.TaxAreaCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Tax Area Code");
            entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");
            entity.Property(e => e.TaxRegistrationNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Tax Registration No_");
            entity.Property(e => e.TelexAnswerBack)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Telex Answer Back");
            entity.Property(e => e.TelexNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Telex No_");
            entity.Property(e => e.TerritoryCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Territory Code");
            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            entity.Property(e => e.TurnoverIncentive)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Turnover Incentive %");
            entity.Property(e => e.TypeOfCustomer).HasColumnName("Type Of Customer");
            entity.Property(e => e.TypeOfMethod).HasColumnName("Type of Method");
            entity.Property(e => e.UsesEArchieve).HasColumnName("Uses E-Archieve");
            entity.Property(e => e.VatBusPostingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VAT Bus_ Posting Group");
            entity.Property(e => e.VatRegistrationNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VAT Registration No_");
            entity.Property(e => e.VendorNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Vendor No_");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Vendor Number");
        });

        modelBuilder.Entity<PilsanPlastikSanVeTicAŞDetailedCustLedgEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Pilsan Plastik San_ve Tic_A_Ş_$Detailed Cust_ Ledg_ Entry");

            entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.AmountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Amount (LCY)");
            entity.Property(e => e.AppliedCustLedgerEntryNo).HasColumnName("Applied Cust_ Ledger Entry No_");
            entity.Property(e => e.CreditAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Credit Amount");
            entity.Property(e => e.CreditAmountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Credit Amount (LCY)");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Currency Code");
            entity.Property(e => e.CustLedgerEntryNo).HasColumnName("Cust_ Ledger Entry No_");
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Customer No_");
            entity.Property(e => e.DebitAmount)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Debit Amount");
            entity.Property(e => e.DebitAmountLcy)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Debit Amount (LCY)");
            entity.Property(e => e.DocumentNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Document No_");
            entity.Property(e => e.DocumentType).HasColumnName("Document Type");
            entity.Property(e => e.EntryNo).HasColumnName("Entry No_");
            entity.Property(e => e.EntryType).HasColumnName("Entry Type");
            entity.Property(e => e.GenBusPostingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Gen_ Bus_ Posting Group");
            entity.Property(e => e.GenProdPostingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Gen_ Prod_ Posting Group");
            entity.Property(e => e.InitialDocumentType).HasColumnName("Initial Document Type");
            entity.Property(e => e.InitialEntryDueDate)
                .HasColumnType("datetime")
                .HasColumnName("Initial Entry Due Date");
            entity.Property(e => e.InitialEntryGlobalDim1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Initial Entry Global Dim_ 1");
            entity.Property(e => e.InitialEntryGlobalDim2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Initial Entry Global Dim_ 2");
            entity.Property(e => e.JournalBatchName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Journal Batch Name");
            entity.Property(e => e.MaxPaymentTolerance)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Max_ Payment Tolerance");
            entity.Property(e => e.PostingDate)
                .HasColumnType("datetime")
                .HasColumnName("Posting Date");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Reason Code");
            entity.Property(e => e.RemainingPmtDiscPossible)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Remaining Pmt_ Disc_ Possible");
            entity.Property(e => e.SourceCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Source Code");
            entity.Property(e => e.TaxJurisdictionCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Tax Jurisdiction Code");
            entity.Property(e => e.Timestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("timestamp");
            entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");
            entity.Property(e => e.UnappliedByEntryNo).HasColumnName("Unapplied by Entry No_");
            entity.Property(e => e.UseTax).HasColumnName("Use Tax");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("User ID");
            entity.Property(e => e.VatBusPostingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VAT Bus_ Posting Group");
            entity.Property(e => e.VatProdPostingGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VAT Prod_ Posting Group");
        });

        modelBuilder.Entity<ServisTicketNot>(entity =>
        {
            entity.HasKey(e => e.NotId);

            entity.ToTable("ServisTicketNot");

            entity.Property(e => e.NotId).HasColumnName("notID");
            entity.Property(e => e.NotAddDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("notAddDate");
            entity.Property(e => e.NotDesc).HasColumnName("notDesc");
            entity.Property(e => e.NotHtDate)
                .HasColumnType("datetime")
                .HasColumnName("notHtDate");
            entity.Property(e => e.NotIsActive).HasColumnName("notIsActive");
            entity.Property(e => e.NotTicketId).HasColumnName("notTicketID");
            entity.Property(e => e.NotTitle)
                .HasMaxLength(255)
                .HasColumnName("notTitle");
            entity.Property(e => e.NotUserId).HasColumnName("notUserID");
        });

        modelBuilder.Entity<ServsisTicket>(entity =>
        {
            entity.HasKey(e => e.MtemId);

            entity.ToTable("ServsisTicket");

            entity.Property(e => e.MtemId).HasColumnName("MtemID");
            entity.Property(e => e.Alarm).HasMaxLength(50);
            entity.Property(e => e.Bayi).HasColumnName("bayi");
            entity.Property(e => e.KisiselNot).UseCollation("Turkish_CI_AS");
            entity.Property(e => e.MusteriAd)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS");
            entity.Property(e => e.MusteriAdres)
                .HasMaxLength(255)
                .UseCollation("Turkish_CI_AS");
            entity.Property(e => e.MusteriSoyAd)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS");
            entity.Property(e => e.ServisUserId).HasColumnName("ServisUserID");
            entity.Property(e => e.SikayetAciklama).UseCollation("Turkish_CI_AS");
            entity.Property(e => e.SikayetEmail)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS");
            entity.Property(e => e.SikayetMobTel)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS");
            entity.Property(e => e.SikayetTel)
                .HasMaxLength(50)
                .UseCollation("Turkish_CI_AS");
            entity.Property(e => e.TemsilciId).HasColumnName("temsilciID");
            entity.Property(e => e.TicketDosya)
                .HasMaxLength(255)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("ticketDosya");
            entity.Property(e => e.TicketPictureUrl)
                .HasMaxLength(255)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("ticketPictureURL");
            entity.Property(e => e.TicketPictureUrl1)
                .HasMaxLength(255)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("ticketPictureURL1");
            entity.Property(e => e.TicketPictureUrl2)
                .HasMaxLength(255)
                .UseCollation("Turkish_CI_AS")
                .HasColumnName("ticketPictureURL2");
            entity.Property(e => e.TicketTalepTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ticketTalepTarihi");
            entity.Property(e => e.Ticketur).HasColumnName("ticketur");
            entity.Property(e => e.UserCentId).HasColumnName("userCentID");
            entity.Property(e => e.UserDistrictId).HasColumnName("userDistrictID");
            entity.Property(e => e.UserParentId).HasColumnName("userParentID");
        });

        modelBuilder.Entity<SikayetSay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sikayetSay");

            entity.Property(e => e.SikayetCihazSeri)
                .HasMaxLength(255)
                .HasColumnName("sikayetCihazSeri");
            entity.Property(e => e.SikayetServisId).HasColumnName("sikayetServisID");
        });

        modelBuilder.Entity<TblApiUser>(entity =>
        {
            entity.Property(e => e.FirmCode).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        modelBuilder.Entity<TblIfst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblIFSTS");

            entity.Property(e => e.IfsCari)
                .HasMaxLength(200)
                .HasColumnName("ifsCari");
            entity.Property(e => e.PilsanCari)
                .HasMaxLength(200)
                .HasColumnName("pilsanCari");
        });

        modelBuilder.Entity<V2021musteriselect>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_2021musteriselect");

            entity.Property(e => e.MusteriAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("musteri_adsoyad");
            entity.Property(e => e.MusteriId)
                .ValueGeneratedOnAdd()
                .HasColumnName("musteriID");
        });

        modelBuilder.Entity<V2023Product>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_2023_product");

            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdBarcodeNo)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeNo");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdName)
                .HasMaxLength(255)
                .HasColumnName("prodName");
            entity.Property(e => e.ProdParentId).HasColumnName("prodParentID");
            entity.Property(e => e.ProdSatisPrice).HasColumnName("prodSatisPrice");
            entity.Property(e => e.TGuncel).HasColumnName("tGuncel");
        });

        modelBuilder.Entity<V2023Siparisler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_2023_siparisler");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.BayiId).HasColumnName("bayiID");
            entity.Property(e => e.BirimFiyat).HasColumnType("money");
            entity.Property(e => e.FaturaAdSoyad).HasMaxLength(255);
            entity.Property(e => e.FaturaNo).HasMaxLength(255);
            entity.Property(e => e.FaturaTelNo).HasMaxLength(255);
            entity.Property(e => e.GuncellemeTarihi).HasMaxLength(50);
            entity.Property(e => e.IfsCariKodu)
                .HasMaxLength(50)
                .HasColumnName("ifs_cari_kodu");
            entity.Property(e => e.IfsSevkAdresi)
                .HasMaxLength(50)
                .HasColumnName("ifs_sevk_adresi");
            entity.Property(e => e.Ip).HasMaxLength(255);
            entity.Property(e => e.KapidaOdeme).HasColumnType("money");
            entity.Property(e => e.KargoFiyati).HasColumnType("money");
            entity.Property(e => e.KargoOdeme)
                .HasMaxLength(50)
                .HasColumnName("kargoOdeme");
            entity.Property(e => e.KargoTeslimatNo).HasMaxLength(255);
            entity.Property(e => e.KargoTipi).HasMaxLength(255);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.PosName).HasMaxLength(255);
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Sebep)
                .HasColumnType("text")
                .HasColumnName("sebep");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisLogId).HasColumnName("siparisLogID");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.Sonuc)
                .HasColumnType("text")
                .HasColumnName("sonuc");
            entity.Property(e => e.TGuncel).HasColumnName("tGuncel");
            entity.Property(e => e.Tarihi).HasColumnType("datetime");
            entity.Property(e => e.TeslimatAdSoyad).HasMaxLength(255);
            entity.Property(e => e.TeslimatTelNo).HasMaxLength(255);
            entity.Property(e => e.UrunAdi).HasMaxLength(255);
            entity.Property(e => e.UrunBarkod).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.VergiDairesi).HasMaxLength(255);
            entity.Property(e => e.VergiNo).HasMaxLength(255);
        });

        modelBuilder.Entity<V2023Siparisler0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_2023_siparisler0");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.BayiId).HasColumnName("bayiID");
            entity.Property(e => e.BirimFiyat).HasColumnType("money");
            entity.Property(e => e.FaturaAdSoyad).HasMaxLength(255);
            entity.Property(e => e.FaturaNo).HasMaxLength(255);
            entity.Property(e => e.FaturaTelNo).HasMaxLength(255);
            entity.Property(e => e.GuncellemeTarihi).HasMaxLength(50);
            entity.Property(e => e.IfsCariKodu)
                .HasMaxLength(50)
                .HasColumnName("ifs_cari_kodu");
            entity.Property(e => e.IfsSevkAdresi)
                .HasMaxLength(50)
                .HasColumnName("ifs_sevk_adresi");
            entity.Property(e => e.Ip).HasMaxLength(255);
            entity.Property(e => e.KapidaOdeme).HasColumnType("money");
            entity.Property(e => e.KargoFiyati).HasColumnType("money");
            entity.Property(e => e.KargoOdeme)
                .HasMaxLength(50)
                .HasColumnName("kargoOdeme");
            entity.Property(e => e.KargoTeslimatNo).HasMaxLength(255);
            entity.Property(e => e.KargoTipi).HasMaxLength(255);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.PosName).HasMaxLength(255);
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.Sebep)
                .HasColumnType("text")
                .HasColumnName("sebep");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisLogId).HasColumnName("siparisLogID");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.Sonuc)
                .HasColumnType("text")
                .HasColumnName("sonuc");
            entity.Property(e => e.TGuncel).HasColumnName("tGuncel");
            entity.Property(e => e.Tarihi).HasColumnType("datetime");
            entity.Property(e => e.TeslimatAdSoyad).HasMaxLength(255);
            entity.Property(e => e.TeslimatTelNo).HasMaxLength(255);
            entity.Property(e => e.UrunAdi).HasMaxLength(255);
            entity.Property(e => e.UrunBarkod).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.VergiDairesi).HasMaxLength(255);
            entity.Property(e => e.VergiNo).HasMaxLength(255);
        });

        modelBuilder.Entity<V2023adminsip>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_2023adminsip");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.ShipName)
                .HasMaxLength(255)
                .HasColumnName("shipName");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisIndirimOrani).HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisOdemeYontemi).HasColumnName("siparisOdemeYontemi");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisTeslimatIlce).HasColumnName("siparisTeslimatIlce");
            entity.Property(e => e.SiparisTeslimatSehir).HasColumnName("siparisTeslimatSehir");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.TakipUrl)
                .HasMaxLength(4000)
                .HasColumnName("takip_url");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VAdminSiparisler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_admin_siparisler");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.FaturaIlIlce)
                .HasMaxLength(308)
                .HasColumnName("fatura_il_ilce");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.OdemeTipi)
                .HasMaxLength(274)
                .HasColumnName("odeme_tipi");
            entity.Property(e => e.ServisId).HasColumnName("servisID");
            entity.Property(e => e.ShipName)
                .HasMaxLength(255)
                .HasColumnName("shipName");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisFaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaAdSoyad");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisIndirimOrani).HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.States).HasColumnName("states");
            entity.Property(e => e.TakipUrl)
                .HasMaxLength(4000)
                .HasColumnName("takip_url");
            entity.Property(e => e.TeslimatIlIlce)
                .HasMaxLength(308)
                .HasColumnName("teslimat_il_ilce");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VAdminSiparisler1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_admin_siparisler1");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.FaturaIlIlce)
                .HasMaxLength(308)
                .HasColumnName("fatura_il_ilce");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.OdemeTipi)
                .HasMaxLength(274)
                .HasColumnName("odeme_tipi");
            entity.Property(e => e.ServisId).HasColumnName("servisID");
            entity.Property(e => e.ShipName)
                .HasMaxLength(255)
                .HasColumnName("shipName");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisFaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaAdSoyad");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisIndirimOrani).HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.States).HasColumnName("states");
            entity.Property(e => e.TakipUrl)
                .HasMaxLength(4000)
                .HasColumnName("takip_url");
            entity.Property(e => e.TeslimatIlIlce)
                .HasMaxLength(308)
                .HasColumnName("teslimat_il_ilce");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VBayiList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_bayiList");

            entity.Property(e => e.Aktif).HasColumnName("aktif");
            entity.Property(e => e.AnaBayi)
                .HasMaxLength(255)
                .HasColumnName("anaBayi");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.FaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("faturaAdSoyad");
            entity.Property(e => e.IfsCariKodu)
                .HasMaxLength(50)
                .HasColumnName("ifs_cari_kodu");
            entity.Property(e => e.IfsSevkAdresi)
                .HasMaxLength(50)
                .HasColumnName("ifs_sevk_adresi");
            entity.Property(e => e.IlIlce)
                .HasMaxLength(308)
                .HasColumnName("ilIlce");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserIsActive).HasColumnName("userIsActive");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
            entity.Property(e => e.UserTel1)
                .HasMaxLength(11)
                .HasColumnName("userTel1");
        });

        modelBuilder.Entity<VDbCariler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_dbCariler");

            entity.Property(e => e.FaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("faturaAdSoyad");
            entity.Property(e => e.FaturaCentId).HasColumnName("faturaCentID");
            entity.Property(e => e.FaturaContent).HasColumnName("faturaContent");
            entity.Property(e => e.FaturaDistrictId).HasColumnName("faturaDistrictID");
            entity.Property(e => e.FaturaTelNo)
                .HasMaxLength(255)
                .HasColumnName("faturaTelNo");
            entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.UserCariId)
                .HasMaxLength(55)
                .HasColumnName("userCariID");
            entity.Property(e => e.UserCustId)
                .HasMaxLength(255)
                .HasColumnName("userCustID");
            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("userID");
            entity.Property(e => e.UserIsActive).HasColumnName("userIsActive");
            entity.Property(e => e.UserKimlikNo)
                .HasMaxLength(255)
                .HasColumnName("userKimlikNo");
            entity.Property(e => e.UserMail)
                .HasMaxLength(255)
                .HasColumnName("userMail");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
            entity.Property(e => e.UserVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("userVergiDairesi");
            entity.Property(e => e.UserVergiNo)
                .HasMaxLength(255)
                .HasColumnName("userVergiNo");
        });

        modelBuilder.Entity<VDbCarilerTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_dbCariler_Test");

            entity.Property(e => e.Aktif).HasColumnName("aktif");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(255)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.FaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("faturaAdSoyad");
            entity.Property(e => e.FaturaCentId).HasColumnName("faturaCentID");
            entity.Property(e => e.FaturaContent)
                .HasMaxLength(255)
                .HasColumnName("faturaContent");
            entity.Property(e => e.FaturaDistrictId).HasColumnName("faturaDistrictID");
            entity.Property(e => e.FaturaTelNo)
                .HasMaxLength(255)
                .HasColumnName("faturaTelNo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PCariKod)
                .HasMaxLength(255)
                .HasColumnName("p_cari_kod");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(255)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.UserCentId).HasColumnName("userCentID");
            entity.Property(e => e.UserDistrictId).HasColumnName("userDistrictID");
            entity.Property(e => e.UserGuid)
                .HasMaxLength(255)
                .HasColumnName("userGUID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserIsActive).HasColumnName("userIsActive");
            entity.Property(e => e.UserKimlikNo)
                .HasMaxLength(255)
                .HasColumnName("userKimlikNo");
            entity.Property(e => e.UserLastLoginDate)
                .HasMaxLength(255)
                .HasColumnName("userLastLoginDate");
            entity.Property(e => e.UserMail)
                .HasMaxLength(255)
                .HasColumnName("userMail");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
            entity.Property(e => e.UserParentId).HasColumnName("userParentID");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasColumnName("userPass");
            entity.Property(e => e.UserPriceType)
                .HasMaxLength(255)
                .HasColumnName("userPriceType");
            entity.Property(e => e.UserTegSoftConId)
                .HasMaxLength(255)
                .HasColumnName("userTegSoftConID");
            entity.Property(e => e.UserType).HasColumnName("userType");
            entity.Property(e => e.UserVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("userVergiDairesi");
            entity.Property(e => e.UserVergiNo)
                .HasMaxLength(255)
                .HasColumnName("userVergiNo");
        });

        modelBuilder.Entity<VDbOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_dbOrders");

            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(251)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.OdemeYontemi)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("odemeYontemi");
            entity.Property(e => e.ShipName)
                .HasMaxLength(255)
                .HasColumnName("shipName");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisBankName)
                .HasMaxLength(255)
                .HasColumnName("siparisBankName");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisOdemeYontemi).HasColumnName("siparisOdemeYontemi");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisPosName)
                .HasMaxLength(255)
                .HasColumnName("siparisPosName");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.StateName)
                .HasMaxLength(255)
                .HasColumnName("stateName");
            entity.Property(e => e.TakipUrl)
                .HasMaxLength(4000)
                .HasColumnName("takip_url");
            entity.Property(e => e.TeslimatIlIlce)
                .HasMaxLength(103)
                .HasColumnName("teslimat_il_ilce");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<VHakedisExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_hakedis_excel");

            entity.Property(e => e.Adres).HasColumnName("adres");
            entity.Property(e => e.AltBayiAdi)
                .HasMaxLength(255)
                .HasColumnName("alt_bayi_adi");
            entity.Property(e => e.AnaBayiAdi)
                .HasMaxLength(255)
                .HasColumnName("ana_bayi_adi");
            entity.Property(e => e.MusteriAdSoyad)
                .HasMaxLength(511)
                .HasColumnName("musteri_ad_soyad");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
        });

        modelBuilder.Entity<VKullanilanMalzemeler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_kullanilanMalzemeler");

            entity.Property(e => e.Ekleyen)
                .HasMaxLength(255)
                .HasColumnName("ekleyen");
            entity.Property(e => e.KulGarantiIsActive).HasColumnName("kulGarantiIsActive");
            entity.Property(e => e.KulId).HasColumnName("kulID");
            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.ProdAdet).HasColumnName("prodAdet");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdFiyat).HasColumnName("prodFiyat");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdName).HasColumnName("prodName");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("recordDate");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.ToplamFiyat).HasColumnName("toplamFiyat");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<VKullanilanMalzemelerE>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_kullanilan_malzemeler_e");

            entity.Property(e => e.GarantiText)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("garantiText");
            entity.Property(e => e.KulGarantiIsActive).HasColumnName("kulGarantiIsActive");
            entity.Property(e => e.KulId).HasColumnName("kulID");
            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.ProdAdet).HasColumnName("prodAdet");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdFiyat).HasColumnName("prodFiyat");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdName)
                .HasMaxLength(545)
                .HasColumnName("prodName");
            entity.Property(e => e.ProdOptId).HasColumnName("prodOptID");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("recordDate");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VKullanilanMalzemelerTumu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_kullanilan_malzemeler_tumu");

            entity.Property(e => e.GarantiText)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("garantiText");
            entity.Property(e => e.KulGarantiIsActive).HasColumnName("kulGarantiIsActive");
            entity.Property(e => e.KulId).HasColumnName("kulID");
            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.ProdAdet).HasColumnName("prodAdet");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdFiyat).HasColumnName("prodFiyat");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdName)
                .HasMaxLength(545)
                .HasColumnName("prodName");
            entity.Property(e => e.ProdOptId).HasColumnName("prodOptID");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("recordDate");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VKullanilanMalzemelerY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_kullanilan_malzemeler_y");

            entity.Property(e => e.GarantiText)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("garantiText");
            entity.Property(e => e.KulGarantiIsActive).HasColumnName("kulGarantiIsActive");
            entity.Property(e => e.KulId).HasColumnName("kulID");
            entity.Property(e => e.LogId).HasColumnName("logID");
            entity.Property(e => e.ProdAdet).HasColumnName("prodAdet");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdFiyat).HasColumnName("prodFiyat");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdName)
                .HasMaxLength(545)
                .HasColumnName("prodName");
            entity.Property(e => e.ProdOptId).HasColumnName("prodOptID");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("recordDate");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VParcaListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_parcaListesi");

            entity.Property(e => e.CatId).HasColumnName("catID");
            entity.Property(e => e.No)
                .HasMaxLength(50)
                .HasColumnName("No_");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdIsActive).HasColumnName("prodIsActive");
            entity.Property(e => e.ProdName).HasColumnName("prodName");
            entity.Property(e => e.ProdOptId).HasColumnName("prodOptID");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.ProdSatisPrice).HasColumnName("prodSatisPrice");
        });

        modelBuilder.Entity<VPilsanIadeSiparisler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_pilsan_iade_siparisler");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("aciklama");
            entity.Property(e => e.BirimFiyat).HasColumnName("birim_fiyat");
            entity.Property(e => e.DonemId).HasColumnName("donemID");
            entity.Property(e => e.DonemUserId).HasColumnName("donemUserID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KulGarantiIsActive).HasColumnName("kulGarantiIsActive");
            entity.Property(e => e.Miktar).HasColumnName("miktar");
            entity.Property(e => e.NavAktar).HasColumnName("Nav_aktar");
            entity.Property(e => e.ProdNo)
                .HasMaxLength(255)
                .HasColumnName("prodNo");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.UserCariId)
                .HasMaxLength(55)
                .HasColumnName("userCariID");
        });

        modelBuilder.Entity<VPilsanSipari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_pilsan_siparis");

            entity.Property(e => e.CariKodu)
                .HasMaxLength(55)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.CustAddress)
                .HasMaxLength(50)
                .HasColumnName("Cust_Address");
            entity.Property(e => e.CustAddress2)
                .HasMaxLength(50)
                .HasColumnName("Cust_Address 2");
            entity.Property(e => e.CustBillToAddress)
                .HasMaxLength(50)
                .HasColumnName("Cust_Bill to Address");
            entity.Property(e => e.CustBillToCity)
                .HasMaxLength(50)
                .HasColumnName("Cust_Bill to City");
            entity.Property(e => e.CustBillToCounty)
                .HasMaxLength(255)
                .HasColumnName("Cust_Bill to County");
            entity.Property(e => e.CustBillToName)
                .HasMaxLength(50)
                .HasColumnName("Cust_Bill to Name");
            entity.Property(e => e.CustBillToPhone)
                .HasMaxLength(20)
                .HasColumnName("Cust_Bill to Phone");
            entity.Property(e => e.CustCity)
                .HasMaxLength(50)
                .HasColumnName("Cust_City");
            entity.Property(e => e.CustCounty)
                .HasMaxLength(255)
                .HasColumnName("Cust_County");
            entity.Property(e => e.CustDeliverToAddress)
                .HasMaxLength(50)
                .HasColumnName("Cust_Deliver to Address");
            entity.Property(e => e.CustDeliverToAddress2)
                .HasMaxLength(50)
                .HasColumnName("Cust_Deliver to Address 2");
            entity.Property(e => e.CustDeliverToCity)
                .HasMaxLength(50)
                .HasColumnName("Cust_Deliver to City");
            entity.Property(e => e.CustDeliverToCounty)
                .HasMaxLength(255)
                .HasColumnName("Cust_Deliver to County");
            entity.Property(e => e.CustDeliverToName)
                .HasMaxLength(255)
                .HasColumnName("Cust_Deliver to Name");
            entity.Property(e => e.CustDeliverToPhone)
                .HasMaxLength(20)
                .HasColumnName("Cust_Deliver to Phone");
            entity.Property(e => e.CustEmail)
                .HasMaxLength(255)
                .HasColumnName("Cust_Email");
            entity.Property(e => e.CustId).HasColumnName("Cust_ID");
            entity.Property(e => e.CustName)
                .HasMaxLength(255)
                .HasColumnName("Cust_Name");
            entity.Property(e => e.CustNavNo)
                .HasMaxLength(50)
                .HasColumnName("Cust_NAV No_");
            entity.Property(e => e.CustPhone)
                .HasMaxLength(20)
                .HasColumnName("Cust_Phone");
            entity.Property(e => e.CustShipToCode)
                .HasMaxLength(50)
                .HasColumnName("Cust_Ship to Code");
            entity.Property(e => e.CustTaxAreaCode)
                .HasMaxLength(100)
                .HasColumnName("Cust_Tax Area Code");
            entity.Property(e => e.CustTaxNo)
                .HasMaxLength(21)
                .HasColumnName("Cust_Tax No_");
            entity.Property(e => e.CustTcNo)
                .HasMaxLength(21)
                .HasColumnName("Cust_TC No_");
            entity.Property(e => e.DetailId).HasColumnName("detailID");
            entity.Property(e => e.Miktar).HasColumnName("miktar");
            entity.Property(e => e.No)
                .HasMaxLength(50)
                .HasColumnName("No_");
            entity.Property(e => e.SalesType).HasColumnName("Sales_Type");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.WebUserName)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("Web_User_Name");
        });

        modelBuilder.Entity<VSerkanson>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_serkanson");

            entity.Property(e => e.BasitUsul).HasColumnName("basitUsul");
            entity.Property(e => e.HakedisDurum).HasColumnName("hakedisDurum");
            entity.Property(e => e.IscilikFiyat).HasColumnName("iscilikFiyat");
            entity.Property(e => e.Kdv).HasColumnName("kdv");
            entity.Property(e => e.LogStateId).HasColumnName("logStateID");
            entity.Property(e => e.SikayetDurum).HasColumnName("sikayetDurum");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SikayetServisId).HasColumnName("sikayetServisID");
            entity.Property(e => e.UserCariId)
                .HasMaxLength(55)
                .HasColumnName("userCariID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.Yol).HasColumnName("YOL");
        });

        modelBuilder.Entity<VServisticket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_servisticket");

            entity.Property(e => e.Alarm).HasMaxLength(50);
            entity.Property(e => e.MtemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MtemID");
            entity.Property(e => e.TemsilciId).HasColumnName("temsilciID");
        });

        modelBuilder.Entity<VSikayetDetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_sikayetDetay");

            entity.Property(e => e.AltBayiAdi)
                .HasMaxLength(255)
                .HasColumnName("altBayiAdi");
            entity.Property(e => e.AltBayiAdres).HasColumnName("altBayiAdres");
            entity.Property(e => e.AltBayiIlce)
                .HasMaxLength(50)
                .HasColumnName("altBayiIlce");
            entity.Property(e => e.AltBayiMail)
                .HasMaxLength(255)
                .HasColumnName("altBayiMail");
            entity.Property(e => e.AltBayiSehir)
                .HasMaxLength(50)
                .HasColumnName("altBayiSehir");
            entity.Property(e => e.AltBayiTelefon)
                .HasMaxLength(255)
                .HasColumnName("altBayiTelefon");
            entity.Property(e => e.AltBayiTelefon1)
                .HasMaxLength(255)
                .HasColumnName("altBayiTelefon1");
            entity.Property(e => e.AltBayiYetkili)
                .HasMaxLength(255)
                .HasColumnName("altBayiYetkili");
            entity.Property(e => e.AnaBayiAdi)
                .HasMaxLength(255)
                .HasColumnName("anaBayiAdi");
            entity.Property(e => e.MusteriIlce)
                .HasMaxLength(50)
                .HasColumnName("musteriIlce");
            entity.Property(e => e.MusteriSehir)
                .HasMaxLength(50)
                .HasColumnName("musteriSehir");
            entity.Property(e => e.Nerelerdesin)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("nerelerdesin");
            entity.Property(e => e.ServisFisNo)
                .HasMaxLength(255)
                .HasColumnName("servisFisNo");
            entity.Property(e => e.SikayetAltBayiId).HasColumnName("sikayetAltBayiID");
            entity.Property(e => e.SikayetBayiId).HasColumnName("sikayetBayiID");
            entity.Property(e => e.SikayetDurum).HasColumnName("sikayetDurum");
            entity.Property(e => e.SikayetGarantiIsActive)
                .HasMaxLength(255)
                .HasColumnName("sikayetGarantiIsActive");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SikayetKimActiId).HasColumnName("sikayetKimActiID");
            entity.Property(e => e.SikayetKimeAit)
                .HasMaxLength(255)
                .HasColumnName("sikayetKimeAit");
            entity.Property(e => e.SikayetMusteriAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriAdi");
            entity.Property(e => e.SikayetMusteriAdresi).HasColumnName("sikayetMusteriAdresi");
            entity.Property(e => e.SikayetMusteriCepTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriCepTelNo");
            entity.Property(e => e.SikayetMusteriMail)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriMail");
            entity.Property(e => e.SikayetMusteriSoyAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriSoyAdi");
            entity.Property(e => e.SikayetMusteriTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriTelNo");
            entity.Property(e => e.SikayetServisId).HasColumnName("sikayetServisID");
            entity.Property(e => e.SikayetTarih)
                .HasColumnType("datetime")
                .HasColumnName("sikayetTarih");
            entity.Property(e => e.SikayetUrunId).HasColumnName("sikayetUrunID");
            entity.Property(e => e.UrunAdi)
                .HasMaxLength(250)
                .HasColumnName("urunAdi");
        });

        modelBuilder.Entity<VSikayetIscilikTutar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_sikayet_iscilik_tutar");

            entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");
            entity.Property(e => e.IscilikToplam).HasColumnName("iscilikToplam");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<VSikayetYolTutar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_sikayet_yol_tutar");

            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SikayetServisId).HasColumnName("sikayetServisID");
            entity.Property(e => e.YolTutar).HasColumnName("yolTutar");
        });

        modelBuilder.Entity<VSiparisMusteriler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_siparis_musteriler");

            entity.Property(e => e.Aktif).HasColumnName("aktif");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.FaturaAdres)
                .HasMaxLength(501)
                .HasColumnName("fatura_adres");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.FaturaIl)
                .HasMaxLength(50)
                .HasColumnName("fatura_il");
            entity.Property(e => e.FaturaIlce)
                .HasMaxLength(255)
                .HasColumnName("fatura_ilce");
            entity.Property(e => e.FaturaTelefon)
                .HasMaxLength(51)
                .HasColumnName("fatura_telefon");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MusteriAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("musteri_adsoyad");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.TeslimatAdres)
                .HasMaxLength(501)
                .HasColumnName("teslimat_adres");
            entity.Property(e => e.TeslimatAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("teslimat_adsoyad");
            entity.Property(e => e.TeslimatIl)
                .HasMaxLength(50)
                .HasColumnName("teslimat_il");
            entity.Property(e => e.TeslimatIlce)
                .HasMaxLength(255)
                .HasColumnName("teslimat_ilce");
            entity.Property(e => e.TeslimatTelefon)
                .HasMaxLength(51)
                .HasColumnName("teslimat_telefon");
        });

        modelBuilder.Entity<VSiparisToplamlari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_siparis_toplamlari");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.FaturaIlIlce)
                .HasMaxLength(308)
                .HasColumnName("fatura_il_ilce");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.OdemeTipi)
                .HasMaxLength(262)
                .HasColumnName("odeme_tipi");
            entity.Property(e => e.ServisId).HasColumnName("servisID");
            entity.Property(e => e.ShipName)
                .HasMaxLength(255)
                .HasColumnName("shipName");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisFaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaAdSoyad");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisIndirimOrani).HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.States).HasColumnName("states");
            entity.Property(e => e.TakipUrl)
                .HasMaxLength(4000)
                .HasColumnName("takip_url");
            entity.Property(e => e.TeslimatIlIlce)
                .HasMaxLength(308)
                .HasColumnName("teslimat_il_ilce");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VSiparisdurumu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_siparisdurumu");
        });

        modelBuilder.Entity<VSiparisler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_siparisler");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.OdemeTipi).HasColumnName("odeme_tipi");
            entity.Property(e => e.ServisId).HasColumnName("servisID");
            entity.Property(e => e.ShipName)
                .HasMaxLength(255)
                .HasColumnName("shipName");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisFaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaAdSoyad");
            entity.Property(e => e.SiparisFaturaIlce).HasColumnName("siparisFaturaIlce");
            entity.Property(e => e.SiparisFaturaSehir).HasColumnName("siparisFaturaSehir");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisIndirimOrani).HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisTeslimatIlce).HasColumnName("siparisTeslimatIlce");
            entity.Property(e => e.SiparisTeslimatSehir).HasColumnName("siparisTeslimatSehir");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VSiparsSerkan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_sipars_serkan");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(255)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.ServisId).HasColumnName("servisID");
            entity.Property(e => e.ShipName)
                .HasMaxLength(255)
                .HasColumnName("shipName");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisFaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaAdSoyad");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisIndirimOrani).HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.StateId).HasColumnName("stateID");
            entity.Property(e => e.StateName)
                .HasMaxLength(255)
                .HasColumnName("stateName");
            entity.Property(e => e.TakipUrl)
                .HasMaxLength(4000)
                .HasColumnName("takip_url");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<VTegSoftContactsToCampaign>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TegSoft_ContactsToCampaign");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KapanisTarih).HasColumnType("datetime");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SikayetMusteriAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriAdi");
            entity.Property(e => e.SikayetMusteriCepTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriCepTelNo");
            entity.Property(e => e.SikayetMusteriSehirId).HasColumnName("sikayetMusteriSehirID");
            entity.Property(e => e.SikayetMusteriSehirText)
                .HasMaxLength(50)
                .HasColumnName("sikayetMusteriSehirText");
            entity.Property(e => e.SikayetMusteriSoyAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriSoyAdi");
            entity.Property(e => e.SikayetMusteriTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriTelNo");
            entity.Property(e => e.StateId).HasColumnName("stateID");
            entity.Property(e => e.StateName)
                .HasMaxLength(255)
                .HasColumnName("stateName");
        });

        modelBuilder.Entity<VTegSoftDbBayiler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TegSoft_dbBayiler");

            entity.Property(e => e.Aktif).HasColumnName("aktif");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.CentNameTegSoft)
                .HasMaxLength(50)
                .HasColumnName("centNameTegSoft");
            entity.Property(e => e.FaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("faturaAdSoyad");
            entity.Property(e => e.FaturaCentId).HasColumnName("faturaCentID");
            entity.Property(e => e.FaturaContent).HasColumnName("faturaContent");
            entity.Property(e => e.FaturaDistrictId).HasColumnName("faturaDistrictID");
            entity.Property(e => e.FaturaTelNo)
                .HasMaxLength(11)
                .HasColumnName("faturaTelNo");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.TeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("teslimatAdSoyad");
            entity.Property(e => e.TeslimatCentId).HasColumnName("teslimatCentID");
            entity.Property(e => e.TeslimatContent).HasColumnName("teslimatContent");
            entity.Property(e => e.TeslimatDistrictId).HasColumnName("teslimatDistrictID");
            entity.Property(e => e.TeslimatTelNo)
                .HasMaxLength(11)
                .HasColumnName("teslimatTelNo");
            entity.Property(e => e.UserBirthDate)
                .HasColumnType("datetime")
                .HasColumnName("userBirthDate");
            entity.Property(e => e.UserCentId).HasColumnName("userCentID");
            entity.Property(e => e.UserDistrictId).HasColumnName("userDistrictID");
            entity.Property(e => e.UserFirstLogin).HasColumnName("userFirstLogin");
            entity.Property(e => e.UserGuid)
                .HasMaxLength(255)
                .HasColumnName("userGUID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserIp)
                .HasMaxLength(255)
                .HasColumnName("userIP");
            entity.Property(e => e.UserIsActive).HasColumnName("userIsActive");
            entity.Property(e => e.UserKimlikNo)
                .HasMaxLength(11)
                .HasColumnName("userKimlikNo");
            entity.Property(e => e.UserLastLoginDate)
                .HasColumnType("datetime")
                .HasColumnName("userLastLoginDate");
            entity.Property(e => e.UserMail)
                .HasMaxLength(255)
                .HasColumnName("userMail");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
            entity.Property(e => e.UserParentId).HasColumnName("userParentID");
            entity.Property(e => e.UserPass)
                .HasMaxLength(255)
                .HasColumnName("userPass");
            entity.Property(e => e.UserPbeden)
                .HasMaxLength(255)
                .HasColumnName("userPBeden");
            entity.Property(e => e.UserPriceType)
                .HasMaxLength(255)
                .HasColumnName("userPriceType");
            entity.Property(e => e.UserTalimatIsActive).HasColumnName("userTalimatIsActive");
            entity.Property(e => e.UserTbeden)
                .HasMaxLength(255)
                .HasColumnName("userTBeden");
            entity.Property(e => e.UserTegSoftConId)
                .HasMaxLength(200)
                .HasColumnName("userTegSoftConID");
            entity.Property(e => e.UserTel1)
                .HasMaxLength(11)
                .HasColumnName("userTel1");
            entity.Property(e => e.UserTel2)
                .HasMaxLength(11)
                .HasColumnName("userTel2");
            entity.Property(e => e.UserTel3)
                .HasMaxLength(11)
                .HasColumnName("userTel3");
            entity.Property(e => e.UserType).HasColumnName("userType");
            entity.Property(e => e.UserVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("userVergiDairesi");
            entity.Property(e => e.UserVergiNo)
                .HasMaxLength(10)
                .HasColumnName("userVergiNo");
        });

        modelBuilder.Entity<VTegSoftDbMusteriler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TegSoft_dbMusteriler");

            entity.Property(e => e.Aktif).HasColumnName("aktif");
            entity.Property(e => e.CariKodu)
                .HasMaxLength(50)
                .HasColumnName("cari_kodu");
            entity.Property(e => e.CentNameTegSoft)
                .HasMaxLength(50)
                .HasColumnName("centNameTegSoft");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DeletedBy).HasColumnName("deletedBy");
            entity.Property(e => e.DeletedDate)
                .HasColumnType("datetime")
                .HasColumnName("deletedDate");
            entity.Property(e => e.FaturaAdres)
                .HasMaxLength(501)
                .HasColumnName("fatura_adres");
            entity.Property(e => e.FaturaAdsoyad)
                .HasMaxLength(251)
                .HasColumnName("fatura_adsoyad");
            entity.Property(e => e.FaturaIl).HasColumnName("fatura_il");
            entity.Property(e => e.FaturaIlce).HasColumnName("fatura_ilce");
            entity.Property(e => e.FaturaTelefon)
                .HasMaxLength(51)
                .HasColumnName("fatura_telefon");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MusteriAdres)
                .HasMaxLength(501)
                .HasColumnName("musteri_adres");
            entity.Property(e => e.MusteriAdsoyad)
                .HasMaxLength(251)
                .HasColumnName("musteri_adsoyad");
            entity.Property(e => e.MusteriEmail)
                .HasMaxLength(101)
                .HasColumnName("musteri_email");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.MusteriIl).HasColumnName("musteri_il");
            entity.Property(e => e.MusteriIlce).HasColumnName("musteri_ilce");
            entity.Property(e => e.MusteriKimlikno)
                .HasMaxLength(21)
                .HasColumnName("musteri_kimlikno");
            entity.Property(e => e.MusteriTelefon)
                .HasMaxLength(51)
                .HasColumnName("musteri_telefon");
            entity.Property(e => e.MusteriVergidairesi)
                .HasMaxLength(100)
                .HasColumnName("musteri_vergidairesi");
            entity.Property(e => e.MusteriVergino)
                .HasMaxLength(21)
                .HasColumnName("musteri_vergino");
            entity.Property(e => e.SevkKodu)
                .HasMaxLength(50)
                .HasColumnName("sevk_kodu");
            entity.Property(e => e.TeslimatAdres)
                .HasMaxLength(501)
                .HasColumnName("teslimat_adres");
            entity.Property(e => e.TeslimatAdsoyad)
                .HasMaxLength(251)
                .HasColumnName("teslimat_adsoyad");
            entity.Property(e => e.TeslimatIl).HasColumnName("teslimat_il");
            entity.Property(e => e.TeslimatIlce).HasColumnName("teslimat_ilce");
            entity.Property(e => e.TeslimatTelefon)
                .HasMaxLength(51)
                .HasColumnName("teslimat_telefon");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
        });

        modelBuilder.Entity<VTegSoftDbSikayetler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TegSoft_dbSikayetler");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SikayetMusteriAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriAdi");
            entity.Property(e => e.SikayetMusteriCepTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriCepTelNo");
            entity.Property(e => e.SikayetMusteriSehirId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("sikayetMusteriSehirID");
            entity.Property(e => e.SikayetMusteriSehirText)
                .HasMaxLength(50)
                .HasColumnName("sikayetMusteriSehirText");
            entity.Property(e => e.SikayetMusteriSoyAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriSoyAdi");
            entity.Property(e => e.SikayetMusteriTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriTelNo");
        });

        modelBuilder.Entity<VTegSoftDbUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TegSoft_dbUsers");

            entity.Property(e => e.CentNameTegSoft)
                .HasMaxLength(50)
                .HasColumnName("centNameTegSoft");
            entity.Property(e => e.FaturaTelNo)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("faturaTelNo");
            entity.Property(e => e.TeslimatTelNo)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("teslimatTelNo");
            entity.Property(e => e.UserCariId)
                .HasMaxLength(55)
                .HasColumnName("userCariID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.UserMail)
                .HasMaxLength(255)
                .HasColumnName("userMail");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
            entity.Property(e => e.UserTel1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("userTel1");
            entity.Property(e => e.UserTel2)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("userTel2");
            entity.Property(e => e.UserTel3)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("userTel3");
            entity.Property(e => e.UserVergiNo)
                .HasMaxLength(255)
                .HasColumnName("userVergiNo");
        });

        modelBuilder.Entity<VUrunler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_urunler");

            entity.Property(e => e.No)
                .HasMaxLength(50)
                .HasColumnName("No_");
            entity.Property(e => e.Pdf1)
                .HasMaxLength(255)
                .HasColumnName("pdf1");
            entity.Property(e => e.Pdf2)
                .HasMaxLength(255)
                .HasColumnName("pdf2");
            entity.Property(e => e.Pdf3)
                .HasMaxLength(255)
                .HasColumnName("pdf3");
            entity.Property(e => e.Pdf4)
                .HasMaxLength(255)
                .HasColumnName("pdf4");
            entity.Property(e => e.Pdf5)
                .HasMaxLength(255)
                .HasColumnName("pdf5");
            entity.Property(e => e.PluralCount).HasColumnName("pluralCount");
            entity.Property(e => e.ProdAlisPrice).HasColumnName("prodAlisPrice");
            entity.Property(e => e.ProdAssessId).HasColumnName("prodAssessID");
            entity.Property(e => e.ProdBannerLink)
                .HasMaxLength(255)
                .HasColumnName("prodBannerLink");
            entity.Property(e => e.ProdBannerUrl)
                .HasMaxLength(255)
                .HasColumnName("prodBannerURL");
            entity.Property(e => e.ProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("prodBarcodeCode");
            entity.Property(e => e.ProdBayiPrice).HasColumnName("prodBayiPrice");
            entity.Property(e => e.ProdCriticStock).HasColumnName("prodCriticStock");
            entity.Property(e => e.ProdDate)
                .HasMaxLength(50)
                .HasColumnName("prodDate");
            entity.Property(e => e.ProdDescription).HasColumnName("prodDescription");
            entity.Property(e => e.ProdHomeIsActive).HasColumnName("prodHomeIsActive");
            entity.Property(e => e.ProdId).HasColumnName("prodID");
            entity.Property(e => e.ProdIndirimPrice).HasColumnName("prodIndirimPrice");
            entity.Property(e => e.ProdIsActive).HasColumnName("prodIsActive");
            entity.Property(e => e.ProdLanguageId).HasColumnName("prodLanguageID");
            entity.Property(e => e.ProdMarkId).HasColumnName("prodMarkID");
            entity.Property(e => e.ProdName)
                .HasMaxLength(255)
                .HasColumnName("prodName");
            entity.Property(e => e.ProdOrderCount).HasColumnName("prodOrderCount");
            entity.Property(e => e.ProdParentId).HasColumnName("prodParentID");
            entity.Property(e => e.ProdPictureUrl)
                .HasMaxLength(255)
                .HasColumnName("prodPictureURL");
            entity.Property(e => e.ProdSatisPrice).HasColumnName("prodSatisPrice");
            entity.Property(e => e.ProdStockCode)
                .HasMaxLength(255)
                .HasColumnName("prodStockCode");
            entity.Property(e => e.ProdStockSize).HasColumnName("prodStockSize");
            entity.Property(e => e.ProdTavsiyePrice).HasColumnName("prodTavsiyePrice");
            entity.Property(e => e.ProdVergiId).HasColumnName("prodVergiID");
            entity.Property(e => e.ProdVideoCatId).HasColumnName("prodVideoCatID");
            entity.Property(e => e.ProdVisitedCount).HasColumnName("prodVisitedCount");
            entity.Property(e => e.SeoName)
                .HasMaxLength(255)
                .HasColumnName("seoName");
            entity.Property(e => e.SingularCount).HasColumnName("singularCount");
        });

        modelBuilder.Entity<VYeniSoru>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_yeniSoru");
        });

        modelBuilder.Entity<VYeniyorum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_yeniyorum");
        });

        modelBuilder.Entity<ViewArizabaglantilari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_arizabaglantilari");

            entity.Property(e => e.ArizaAdi)
                .HasMaxLength(255)
                .HasColumnName("arizaAdi");
            entity.Property(e => e.ArizaKodu)
                .HasMaxLength(255)
                .HasColumnName("arizaKodu");
            entity.Property(e => e.ProdCatName)
                .HasMaxLength(250)
                .HasColumnName("prodCatName");
        });

        modelBuilder.Entity<VwOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwOrders");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.BayiId).HasColumnName("bayiID");
            entity.Property(e => e.KargoOdeme)
                .HasMaxLength(50)
                .HasColumnName("kargoOdeme");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.SalesType).HasColumnName("Sales_Type");
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisBankName)
                .HasMaxLength(255)
                .HasColumnName("siparisBankName");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisFaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaAdSoyad");
            entity.Property(e => e.SiparisFaturaAdresi).HasColumnName("siparisFaturaAdresi");
            entity.Property(e => e.SiparisFaturaIlce).HasColumnName("siparisFaturaIlce");
            entity.Property(e => e.SiparisFaturaNo)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaNo");
            entity.Property(e => e.SiparisFaturaSehir).HasColumnName("siparisFaturaSehir");
            entity.Property(e => e.SiparisFaturaTelNo)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaTelNo");
            entity.Property(e => e.SiparisGuncellemeTarihi)
                .HasMaxLength(50)
                .HasColumnName("siparisGuncellemeTarihi");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisIndirimOrani).HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisIp)
                .HasMaxLength(255)
                .HasColumnName("siparisIP");
            entity.Property(e => e.SiparisKapidaOdeme)
                .HasColumnType("money")
                .HasColumnName("siparisKapidaOdeme");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisLogId).HasColumnName("siparisLogID");
            entity.Property(e => e.SiparisMagazaNotu).HasColumnName("siparisMagazaNotu");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisNot).HasColumnName("siparisNot");
            entity.Property(e => e.SiparisNot1).HasColumnName("siparisNot1");
            entity.Property(e => e.SiparisOdemeYontemi).HasColumnName("siparisOdemeYontemi");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisPosName)
                .HasMaxLength(255)
                .HasColumnName("siparisPosName");
            entity.Property(e => e.SiparisPosOrderId).HasColumnName("siparisPosOrderID");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisTeslimatAdres).HasColumnName("siparisTeslimatAdres");
            entity.Property(e => e.SiparisTeslimatIlce).HasColumnName("siparisTeslimatIlce");
            entity.Property(e => e.SiparisTeslimatSehir).HasColumnName("siparisTeslimatSehir");
            entity.Property(e => e.SiparisTeslimatTelNo)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatTelNo");
            entity.Property(e => e.SiparisTutar).HasColumnName("siparisTutar");
            entity.Property(e => e.SiparisUrunler).HasColumnName("siparisUrunler");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.SiparisVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("siparisVergiDairesi");
            entity.Property(e => e.SiparisVergiNo)
                .HasMaxLength(255)
                .HasColumnName("siparisVergiNo");
            entity.Property(e => e.StateColor)
                .HasMaxLength(255)
                .HasColumnName("stateColor");
            entity.Property(e => e.StateId).HasColumnName("stateID");
            entity.Property(e => e.StateName)
                .HasMaxLength(255)
                .HasColumnName("stateName");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<VwPilsanTegsoft>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPilsanTegsoft");

            entity.Property(e => e.ErrorMessage).HasColumnName("errorMessage");
            entity.Property(e => e.Ilce).HasMaxLength(255);
            entity.Property(e => e.PlsTelefonDegisti).HasColumnName("plsTelefonDegisti");
            entity.Property(e => e.PlsTelefonGonderildi).HasColumnName("plsTelefonGonderildi");
            entity.Property(e => e.Sehir).HasMaxLength(50);
            entity.Property(e => e.SikayetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("sikayetID");
            entity.Property(e => e.SikayetMusteriAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriAdi");
            entity.Property(e => e.SikayetMusteriCepTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriCepTelNo");
            entity.Property(e => e.SikayetMusteriSoyAdi)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriSoyAdi");
            entity.Property(e => e.SikayetMusteriTelNo)
                .HasMaxLength(255)
                .HasColumnName("sikayetMusteriTelNo");
        });

        modelBuilder.Entity<VwSiparisDurumAktarimi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VwSiparisDurumAktarimi");

            entity.Property(e => e.DetailId).HasColumnName("detailID");
            entity.Property(e => e.DetailOrderId).HasColumnName("detailOrderID");
            entity.Property(e => e.DetailProdBarcodeCode)
                .HasMaxLength(255)
                .HasColumnName("detailProdBarcodeCode");
            entity.Property(e => e.DetailProdCount).HasColumnName("detailProdCount");
            entity.Property(e => e.DetailProdId).HasColumnName("detailProdID");
            entity.Property(e => e.DetailProdPrice)
                .HasColumnType("money")
                .HasColumnName("detailProdPrice");
            entity.Property(e => e.LowDesc)
                .HasMaxLength(255)
                .HasColumnName("lowDesc");
            entity.Property(e => e.ProdBirim).HasColumnName("prodBirim");
            entity.Property(e => e.ProdBirimDesc).HasColumnName("prodBirimDesc");
            entity.Property(e => e.ProdName)
                .HasMaxLength(255)
                .HasColumnName("prodName");
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.SiparisGuncellemeTarihi)
                .HasMaxLength(50)
                .HasColumnName("siparisGuncellemeTarihi");
            entity.Property(e => e.SiparisId).HasColumnName("siparisID");
            entity.Property(e => e.SiparisOdemeYontemi).HasColumnName("siparisOdemeYontemi");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTutar).HasColumnName("siparisTutar");
        });

        modelBuilder.Entity<VwdbOrdersTegsoft>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwdbOrdersTegsoft");

            entity.Property(e => e.AltBayiId).HasColumnName("altBayiID");
            entity.Property(e => e.BayiId).HasColumnName("bayiID");
            entity.Property(e => e.Durum).HasMaxLength(255);
            entity.Property(e => e.KargoOdeme)
                .HasMaxLength(50)
                .HasColumnName("kargoOdeme");
            entity.Property(e => e.MusteriId).HasColumnName("musteriID");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .HasColumnName("phone");
            entity.Property(e => e.SalesType).HasColumnName("Sales_Type");
            entity.Property(e => e.SehirName).HasMaxLength(50);
            entity.Property(e => e.SikayetId).HasColumnName("sikayetID");
            entity.Property(e => e.SiparisBankName)
                .HasMaxLength(255)
                .HasColumnName("siparisBankName");
            entity.Property(e => e.SiparisDurumu).HasColumnName("siparisDurumu");
            entity.Property(e => e.SiparisFaturaAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaAdSoyad");
            entity.Property(e => e.SiparisFaturaAdresi).HasColumnName("siparisFaturaAdresi");
            entity.Property(e => e.SiparisFaturaIlce).HasColumnName("siparisFaturaIlce");
            entity.Property(e => e.SiparisFaturaNo)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaNo");
            entity.Property(e => e.SiparisFaturaSehir).HasColumnName("siparisFaturaSehir");
            entity.Property(e => e.SiparisFaturaTelNo)
                .HasMaxLength(255)
                .HasColumnName("siparisFaturaTelNo");
            entity.Property(e => e.SiparisGuncellemeTarihi)
                .HasMaxLength(50)
                .HasColumnName("siparisGuncellemeTarihi");
            entity.Property(e => e.SiparisId)
                .ValueGeneratedOnAdd()
                .HasColumnName("siparisID");
            entity.Property(e => e.SiparisIndirimOrani).HasColumnName("siparisIndirimOrani");
            entity.Property(e => e.SiparisIp)
                .HasMaxLength(255)
                .HasColumnName("siparisIP");
            entity.Property(e => e.SiparisKapidaOdeme)
                .HasColumnType("money")
                .HasColumnName("siparisKapidaOdeme");
            entity.Property(e => e.SiparisKargoFiyati)
                .HasColumnType("money")
                .HasColumnName("siparisKargoFiyati");
            entity.Property(e => e.SiparisKargoTeslimatNo)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTeslimatNo");
            entity.Property(e => e.SiparisKargoTipi)
                .HasMaxLength(255)
                .HasColumnName("siparisKargoTipi");
            entity.Property(e => e.SiparisLogId).HasColumnName("siparisLogID");
            entity.Property(e => e.SiparisMagazaNotu).HasColumnName("siparisMagazaNotu");
            entity.Property(e => e.SiparisMail)
                .HasMaxLength(50)
                .HasColumnName("siparisMail");
            entity.Property(e => e.SiparisNot).HasColumnName("siparisNot");
            entity.Property(e => e.SiparisNot1).HasColumnName("siparisNot1");
            entity.Property(e => e.SiparisOdemeYontemi).HasColumnName("siparisOdemeYontemi");
            entity.Property(e => e.SiparisOlusturan).HasColumnName("siparisOlusturan");
            entity.Property(e => e.SiparisPosName)
                .HasMaxLength(255)
                .HasColumnName("siparisPosName");
            entity.Property(e => e.SiparisPosOrderId).HasColumnName("siparisPosOrderID");
            entity.Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("siparisTarihi");
            entity.Property(e => e.SiparisTeslimatAdSoyad)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatAdSoyad");
            entity.Property(e => e.SiparisTeslimatAdres).HasColumnName("siparisTeslimatAdres");
            entity.Property(e => e.SiparisTeslimatIlce).HasColumnName("siparisTeslimatIlce");
            entity.Property(e => e.SiparisTeslimatSehir).HasColumnName("siparisTeslimatSehir");
            entity.Property(e => e.SiparisTeslimatTelNo)
                .HasMaxLength(255)
                .HasColumnName("siparisTeslimatTelNo");
            entity.Property(e => e.SiparisTutar).HasColumnName("siparisTutar");
            entity.Property(e => e.SiparisUrunler).HasColumnName("siparisUrunler");
            entity.Property(e => e.SiparisUserId).HasColumnName("siparisUserID");
            entity.Property(e => e.SiparisVergiDairesi)
                .HasMaxLength(255)
                .HasColumnName("siparisVergiDairesi");
            entity.Property(e => e.SiparisVergiNo)
                .HasMaxLength(255)
                .HasColumnName("siparisVergiNo");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
