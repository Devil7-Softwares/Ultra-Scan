Imports DevExpress.Office.Utils
Imports DevExpress.Pdf
Imports DevExpress.XtraBars.Ribbon

Public Class PDF

    Shared Sub ExportPDF(ByVal Pages As GalleryItemGroup, ByVal FileName As String)
        Using Processor As New PdfDocumentProcessor
            Processor.CreateEmptyDocument()
            For Each Image As GalleryItem In Pages.Items
                Dim Width As Single = Units.PixelsToPoints(Image.Image.Width, Image.Image.HorizontalResolution)
                Dim height As Single = Units.PixelsToPoints(Image.Image.Height, Image.Image.HorizontalResolution)
                Using G As PdfGraphics = Processor.CreateGraphics
                    G.DrawImage(Image.Image, New PointF(0, 0))
                    Processor.RenderNewPage(New PdfRectangle(0, 0, Width, height), G, Image.Image.HorizontalResolution, Image.Image.VerticalResolution)
                End Using
            Next
            Processor.SaveDocument(FileName)
        End Using
    End Sub

End Class
