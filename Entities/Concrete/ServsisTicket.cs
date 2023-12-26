using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class ServsisTicket
{
    public int MtemId { get; set; }

    public int TemsilciId { get; set; }

    public int? NotKont { get; set; }

    public string? MusteriAd { get; set; }

    public string? MusteriSoyAd { get; set; }

    public string? SikayetTel { get; set; }

    public string? SikayetMobTel { get; set; }

    public string? SikayetEmail { get; set; }

    public string? MusteriAdres { get; set; }

    public int? UserCentId { get; set; }

    public int? UserDistrictId { get; set; }

    public int? SikayetTur { get; set; }

    public string? SikayetAciklama { get; set; }

    public int? Hatirlatma { get; set; }

    public string? Alarm { get; set; }

    public int? SikayetDurum { get; set; }

    public int? ServisUserId { get; set; }

    public string? KisiselNot { get; set; }

    public string? TicketPictureUrl { get; set; }

    public DateTime? TicketTalepTarihi { get; set; }

    public int? Ticketur { get; set; }

    public int? Bayi { get; set; }

    public int? UserParentId { get; set; }

    public string? TicketPictureUrl1 { get; set; }

    public string? TicketPictureUrl2 { get; set; }

    public string? TicketDosya { get; set; }
}
