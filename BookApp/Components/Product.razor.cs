using BookApp.Model;
using Microsoft.AspNetCore.Components;
using QRCoder;
using System.Drawing.Imaging;
using Net.ConnectCode.BarcodeFontsStandard2D;
namespace BookApp.Components;

public partial class Product
{
    private string _qrCode;
    [Parameter] public Book Book { get; set; }
    
}