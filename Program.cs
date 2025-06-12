// ================================
// PROGRAMA PRINCIPAL
// ================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using StructuralPatterns.Adapter;
using StructuralPatterns.Bridge;
using StructuralPatterns.Composite;
using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
using StructuralPatterns.Flyweight;
using StructuralPatterns.Proxy;
using BehavioralPatterns.ChainOfResponsibility;
using BehavioralPatterns.Command;
using BehavioralPatterns.Interpreter;
using BehavioralPatterns.Iterator;
using BehavioralPatterns.Mediator;
using BehavioralPatterns.Memento;
using BehavioralPatterns.Observer;
using BehavioralPatterns.State;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.TemplateMethod;
using BehavioralPatterns.Visitor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DEMONSTRAÇÃO DOS PADRÕES DE PROJETO");
        Console.WriteLine("====================================");

        // PADRÕES ESTRUTURAIS
        Console.WriteLine("\nPADRÕES ESTRUTURAIS:");
        AdapterDemo.Execute();
        BridgeDemo.Execute();
        CompositeDemo.Execute();
        DecoratorDemo.Execute();
        FacadeDemo.Execute();
        FlyweightDemo.Execute();
        ProxyDemo.Execute();

        // PADRÕES COMPORTAMENTAIS
        Console.WriteLine("\n\nPADRÕES COMPORTAMENTAIS:");
        ChainOfResponsibilityDemo.Execute();
        CommandDemo.Execute();
        InterpreterDemo.Execute();
        // Iterator
            Console.WriteLine("4. Iterator:");
            var playlist = new BehavioralPatterns.Iterator.Playlist();
            playlist.Add("Song 1");
            playlist.Add("Song 2");
            playlist.Add("Song 3");
            foreach (var song in playlist)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine();
        MediatorDemo.Execute();
        MementoDemo.Execute();
        ObserverDemo.Execute();
        StateDemo.Execute();
        StrategyDemo.Execute();
        TemplateMethodDemo.Execute();
        VisitorDemo.Execute();

        // Console.WriteLine("\n\nPressione qualquer tecla para sair...");
        // Console.ReadKey();
    }
}