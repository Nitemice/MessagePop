MessagePop 
=============================
**v1.2.5**
By Nitemice, 2013

Contents 
--------
1. [System Requirements](#1-system-requirements)
2. [Overview](#2-overview)
3. [Installation](#3-installation)
4. [Usage](#4-usage)
5. [Source Code Usage Instructions](#5-source-code-usage-instructions)
6. [Version History](#6-version-history)
7. [Terms of Use & Disclaimer](#7-terms-of-use--disclaimer)
8. [Contact Information](#8-contact-information)


1. System Requirements
----------------------

- Windows Vista onwards
- about 1 megabyte of free space on hard disk
- about 30 megabytes of free memory

2. Overview 
-----------

MessagePop is a simple program for displaying a message, which you set via command line arguments, in a window which stays on top of any other windows.
You can set the body text, title text and OK/close-button text.

3. Installation 
---------------

MessagePop is too simple to have an installer. Just copy the .exe to wherever you want to use it from. I suggest you create a new folder at `C:\Program Files\Nitemice Software`, and put in there. 

4. Usage 
--------

So the basics of how to use MessagePop are:

- You run the program however you want, with the message as a command line parameter. 
- You can also set the title text and the button text by simply putting a hash `#` with a space on both side, and then the next bit of text. So to specify all three, it should look something like this: 

```
This is my message. # Titles are cool! # Press the button! 
```

- You can skip entering a message or title text if you want by hashing past it, e.g. if you don't want to specify a title, but you do want to specify the button text, write your message, and then adding `space hash space hash space` (` # # `) and then type what you want the button to say. 
- You can quickly close MessagePop by hitting either the Enter or Escape keys.

MessagePop can be used in various ways. It can be run on a schedule like an alarm, from command line as a warning or alert prompt, or from a shortcut for some reason.
If you've got an idea for how to use MessagePop, go ahead! And tell me, because I'd love to know!

5. Source Code Usage Instructions 
---------------------------------

To see the source code, go to [www.github.com/Nitemice/MessagePop](www.github.com/Nitemice/MessagePop), and it's now all there. To play around with it, download all the files and open the .VBProj file in Visual Studio, and it should load all the files you need.

6. Version History 
------------------

* 1.2.5 (19/9/2013) : Made adjustments for upload to GitHub & added licence
* 1.2 (25/5/2013) : Added ability to skip specifying message and/or title
* 1.1 (16/5/2013) : Initial release build
* 1.0 (8/5/2013) : Initial concept build

7. Terms of Use & Disclaimer 
----------------------

This software is licensed under The MIT License (MIT)
Copyright (c) 2013 Nitemice

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

8. Contact Information 
----------------------

**Nitemice Software**  
  Visit my site: [http://nitemice.net](http://nitemice.net)  
  Email me: contact@nitemice.net  