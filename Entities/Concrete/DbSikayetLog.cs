using System;
using System.Collections.Generic;

namespace Entities.Concrete;

public partial class DbSikayetLog
{
    public int LogId { get; set; }

    public int? LogSikayetId { get; set; }

    public int LogOkunduOnay { get; set; }

    public DateTime? LogOkunduTarih { get; set; }

    public int? LogStateId { get; set; }

    public int? SikayetServisId { get; set; }

    public int? LogUserId { get; set; }

    public byte? LogUserIsAdmin { get; set; }

    public string? LogDate { get; set; }

    public DateTime? LogDateTest { get; set; }

    public string? LogDescription { get; set; }

    public DateTime? LogRandevu { get; set; }

    public string? LogYolKm { get; set; }

    public int? LogarizaId { get; set; }

    public string? LogRandevUser { get; set; }

    public string? LogRandevuSaveUser { get; set; }

    public double? LogYolKmBedel { get; set; }

    public string? LogTalepDate { get; set; }

    public string? LogTalepOnayId { get; set; }

    public string? LogTalepOnayUserId { get; set; }

    public string? LogTalepOnayDescription { get; set; }

    public string? LogRandevuDescription { get; set; }

    public int? Logiptalsecenek { get; set; }

    public string? LogTalepOnayDate { get; set; }

    public int? LogTalepOnayKm { get; set; }

    public string? LogEskiAkuSerial { get; set; }

    public string? LogYeniAkuSerial { get; set; }

    public string? LogMalzemeler { get; set; }
}
