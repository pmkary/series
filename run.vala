
// Copyright 2014 Pouya Kary, All rights reserved

// This is one handy shortcut for running any kind of long apps in UNIX

//
// to compile this file use:
// valac -o series --pkg posix ./run.vala
//

using GLib;
using Posix;

public class Run : Object {

    public static void main(string[] args) {
              
        string app_args = "" ;  

        //
        // Replace <ReplaceWithThePathOfYourArcadeDirectoryAndAddress> with your files path
        //

        string app_name = "mono '/Users/pmk/Dropbox/Document/Source Codes/KarySeries/series/bin/Debug/series.exe'";
       
        for (int i = 1 ; i < args.length ; i++) {
           string arg = args[i].to_string() ;
           app_args = app_args + " '" + arg + "'" ;
        }

        Posix.system( app_name + app_args ); 
    }
}

// done
