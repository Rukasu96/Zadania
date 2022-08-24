using Lekcja2_2;


Dokument d = new Dokument();
ICSV csv = (ICSV)d;
csv.Write();

IExcel excel = (IExcel)d;
excel.Write();