# Kary Series

It's a game about mathematical sequences. In each level you will get a seqaunces like this:

```
   ┌─────────────┬─────────────────────────────────────────────────┐
   │ KARY SERIES │::: Q U E S T I O N :::::::::::::::::::::::::::::│
   ├─────────────┴─────────────────────────────────────────────────┤
   │                                                               │
   │                                                               │
   │ Level 4 = 1, 3, 7, 12, 18, 26, 35, 45, 56, 69                 │
   │                                                               │
   │                                                               │
   └───────────────────────────────────────────────────────────────┘
   ┌─────────────┬─────────────────────────────────────────────────┐
   │ KARY SERIES │::: I N P U T :::::::::::::::::::::::::::::::::::│
   └─────────────┴─────────────────────────────────────────────────┘

    >>> 
```

And then you have to write a formula for it. The systems is powered by [NCalc](http://ncalc.codeplex.com/) so you have all the power there to write exactly any kind of the formula you want. 

There are two parameters you can use to write your formulas with. First one is `x` that is the index number of the sequence and `p` as the value of the previous index's value. 

In each level if you give a bad formula Series will give you some damn good feedbacks that will help you to get closer:


```
   ┌─────────────┬─────────────────────────────────────────────────┐
   │ KARY SERIES │::: F A I L E D :::::::::::::::::::::::::::::::::│
   ├─────────────┴─────────────────────────────────────────────────┤
   │                                                               │
   │ Your formula is no match to our sequance. Here you can see    │
   │ the first 10 index of your evaluated formula:                 │
   │                                                               │
   │  #   │ Test Results            │ Expectations                 │
   │ ─────┼─────────────────────────┼───────────────────────────── │
   │  1   │ 1                       │ 1                            │
   │  2   │ 3                       │ 3                            │
   │  3   │ 5                       │ 7                            │
   │  4   │ 7                       │ 12                           │
   │  5   │ 9                       │ 18                           │
   │  6   │ 11                      │ 26                           │
   │  7   │ 13                      │ 35                           │
   │  8   │ 15                      │ 45                           │
   │  9   │ 17                      │ 56                           │
   │  10  │ 19                      │ 69                           │
   │                                                               │
   └───────────────────────────────────────────────────────────────┘
```

make sure you make it to see:

```
   ┌┬────────┬─────────────────────────────────────────────────────┐
   ││  KARY  │                                                     │
   │└────────┘                                                     │
   │                                                               │
   │                                                               │
   │          __     __          __          __         _          │
   │          \ \   / /          \ \        / /        | |         │
   │           \ \_/ /__  _   _   \ \  /\  / /__  _ __ | |         │
   │            \   / _ \| | | |   \ \/  \/ / _ \| '_ \| |         │
   │             | | (_) | |_| |    \  /\  / (_) | | | |_|         │
   │             |_|\___/ \__,_|     \/  \/ \___/|_| |_(_)         │
   │                                                               │
   │         Congratulations! You proved to be a great mater       │
   │          in understanding sequences! Well done, Truly!        │
   │                                                               │
   │                                                               │
   │                                                               │
   │                                                               │
   └───────────────────────────────────────────────────────────────┘
```
## Libs you need

You have to include [Panther](https://github.com/karysystems/panther) and [NCalc](http://ncalc.codeplex.com/).

## Thanks

Thanks to Helftone for [MonoDraw](http://monodraw.helftone.com/) that I used to design the whole interface with and guys at [NCalc](ncalc.codeplex.com) because of what powers Series.

## License

```
Kary Series - A game of mathematical sequences
Copyright (c) 2015 Pouya Kary <k@arendelle.org>


This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
```
