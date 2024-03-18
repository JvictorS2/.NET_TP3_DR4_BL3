using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.ComponentModel.DataAnnotations;

namespace TP3_.NET.Models;

public class Computador 
{
    private int id;
    private string? marca;
    private string? processador;
    private string? placaMae;
    private float memoria;
    private float hD;
    private string? numeroPratrimonio;
    private string? dataCompra;
    [Key]
    public int Id { get => id; set => id = value; }
    [Required]
    public string? Marca { get => marca; set => marca = value; }
    [Required]
    public string? Processador { get => processador; set => processador = value; }
    [Required]
    public string? PlacaMae { get => placaMae; set => placaMae = value; }
    [Required]
    public float Memoria { get => memoria; set => memoria = value; }
    [Required]
    public float HD { get => hD; set => hD = value; }
    [Required]
    public string? NumeroPratrimonio { get => numeroPratrimonio; set => numeroPratrimonio = value; }
    [Required]
    public string? DataCompra { get => dataCompra; set => dataCompra = value; }
}

