# Simple.Wpf.Exceptions.5.0

[![Build status](https://ci.appveyor.com/api/projects/status/72staf3ivfet3699?svg=true)](https://https://ci.appveyor.com/project/oriches/simple-wpf-exceptions-5-0)

A port/migration of [Simple.Wpf.Exceptions](https://github.com/oriches/Simple.Wpf.Exceptions) WPF app from .Net 4.8 Framework to .Net 5.0.

Note: Used the [MS Upgrade Tool](https://dotnet.microsoft.com/platform/upgrade-assistant/tutorial/install-upgrade-assistant), and then had to do some manual fixup afterwards.

Main issue was related to the use of System.Reactive 5.0, for some reason it was not pucking up DispatcherScheduler from System.Reactive.Concurrency, adding nuGet reference to ReactiveUI solved this issue.
