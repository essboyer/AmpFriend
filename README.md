AmpFriend
=========

A handy utility to assist in doing regular tube amp related maintenance.

Amp Friend is a quick 'n dirty application I have created for personal use. At present, it is ugly as hell, and probably buggy.
It also lacks many features. I've put it on Github to help inspire myself to do more to the tool, so that it someday might be useful
for other technicians out there.

What does it do?
================

In a nutshell, it's a time-saving calculator, which allows you to enter either the **RMS voltage**, **Peak-to-peak voltage**, or the desired power output in **watts**. The calculator will then display the expected voltage/wattage at 2, 4, 8 and 16 ohms. These numbers are consistent with the results checked against a static load, therefore, test frequency shouldn't matter.

OS Compatibility
================

The application is writen in **C#**, in SharpDevelop, but it will also work as a Visual Studio project, if that's your thing. It also works with MonoDevelop, and has been tested using Mono 4.5 on Fedora Linux. No reason for it to not work with Mono on Mac, as far as I can see.

At present, there are no dependencies outside of the core .NET/Mono library aside from some freeware TT fonts used on Windows. I think I can embed these in the project, but as of this writing have been too lazy to do so. Oh well!
