using ConsoleAppNonVirtualStaticInterfaceMembers.Interfaces;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 11 + C# 15 | Non-virtual static interface members *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

double milhas = 500;
Console.WriteLine($"{milhas} milhas equivalem a {IConversorDistancias.MilhasParaKm(milhas)} km");

double km = 1237.5;
Console.WriteLine($"{km} km equivalem a {IConversorDistancias.KmParaMilhas(km)} milhas");