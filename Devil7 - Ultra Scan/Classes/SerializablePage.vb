Imports System.ComponentModel
Imports System.Xml.Serialization

Public Class SerializablePage

#Region "Properties"
    <XmlIgnore>
    Property Bitmap As Bitmap

    <Browsable(False)>
    Property BitmapData As Byte()
        Get
            Using MS As New IO.MemoryStream
                Bitmap.Save(MS, Imaging.ImageFormat.Bmp)
                Return MS.ToArray
            End Using
        End Get
        Set(value As Byte())
            Using MS As New IO.MemoryStream(value)
                Bitmap = Image.FromStream(MS)
            End Using
        End Set
    End Property

    Property Caption As String
    Property Description As String
#End Region

#Region "Constructor"
    Sub New()
        Me.New(Nothing, "", "")
    End Sub

    Sub New(ByVal Bitmap As Bitmap, ByVal Caption As String, ByVal Description As String)
        Me.Bitmap = Bitmap
        Me.Caption = Caption
        Me.Description = Description
    End Sub
#End Region

#Region "Public Functions"
    Public Shared Function ConvertPages(ByVal Pages As DevExpress.XtraBars.Ribbon.GalleryItemGroup) As List(Of SerializablePage)
        Dim R As New List(Of SerializablePage)

        For Each i As DevExpress.XtraBars.Ribbon.GalleryItem In Pages.Items
            R.Add(New SerializablePage(i.Image, i.Caption, i.Description))
        Next

        Return R
    End Function

    Public Shared Sub ParsePages(ByVal Pages As DevExpress.XtraBars.Ribbon.GalleryItemGroup, ByVal SerializablePages As List(Of SerializablePage))
        Pages.Items.Clear()
        For Each i As SerializablePage In SerializablePages
            Pages.Items.Add(New DevExpress.XtraBars.Ribbon.GalleryItem(i.Bitmap, i.Caption, i.Description))
        Next
    End Sub

#End Region

End Class
