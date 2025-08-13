using System;
using System.Diagnostics;
using System.Text;
using ColombianCoffee.Src.Shared.Helpers;
using IronPdf;



class Program
{
    static void Main(string[] args)
    {
        string baseDir = AppContext.BaseDirectory;
        string imgDir = Path.Combine(baseDir, "assets", "images");
        string logo = Path.Combine(imgDir, "androide.jpeg");

        IronPdf.License.LicenseKey = "IRONSUITE.CORZOSANCHEZEDWINCAMILO971.GMAIL.COM.15625-BFF24DA3D8-A33DGVDKLL3AXZ3H-SPUJ7B4NIOV3-HHMACBDCXASQ-VPQH7ALZWY6V-BYXUAVBYLVLV-QCBFHUD3HFIO-55NUUT-TF5T6FMXQIGQEA-DEPLOYMENT.TRIAL-X4WR6G.TRIAL.EXPIRES.11.SEP.2025";

        using var db = DbContextFactory.Create();

        var variedades = db.variedadescafe.ToList();

        var html = new StringBuilder();
        html.Append($"<img src='{logo}' style='display:block; margin:auto; width:200px;' />");
        html.Append("<h1 style='text-align:center;'>Catálogo de Variedades de Café</h1>");
        html.Append("<table border='1' cellspacing='0' cellpadding='5' style='width:100%; border-collapse:collapse; text-align:center;'>");
        html.Append("<tr><th>Nombre</th><th>Porte</th><th>Tamaño Grano</th><th>Altitud</th><th>Resistencia Roya</th></tr>");

        foreach (var v in variedades)
        {
            html.Append($"<tr>" +
                        $"<td>{v.Nombre}</td>" +
                        $"<td>{v.Porte}</td>" +
                        $"<td>{v.TamanoGrano}</td>" +
                        $"<td>{v.AltitudOptima}</td>" +
                        $"<td>{v.ResistenciaRoya}</td>" +
                        "</tr>");
        }

        html.Append("</table>");

        var renderer = new ChromePdfRenderer();
        var pdf = renderer.RenderHtmlAsPdf(html.ToString());
        pdf.SaveAs("CatalogosCafe.pdf");

        Console.WriteLine("✅ PDF generado con datos de MySQL");
        AbrirImagen(logo);
    }
    static void AbrirImagen(string ruta)
    {
        if (!File.Exists(ruta))
        {
            Console.WriteLine("No existe: " + ruta);
            return;
        }

        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = ruta,
                UseShellExecute = true // clave: abre con la app asociada
            });
        }
        catch
        {
            // Fallback según SO
            if (OperatingSystem.IsWindows())
                Process.Start(new ProcessStartInfo("explorer", $"{ ruta }") { CreateNoWindow = true });
            else if (OperatingSystem.IsLinux())
                Process.Start("xdg-open", $"{ ruta }");   // requiere xdg-utils
            else if (OperatingSystem.IsMacOS())
                Process.Start("open", $"{ ruta }");
            else
                throw;
        }
    }
}

