Common Lisp Reasoner, Version 3.3.2


What is it?
-----------

The Common Lisp Reasoner extends the Common Lisp Object System (CLOS) to
incorporate a powerful rule language suitable for all kinds of reasoning
tasks, vanilla XML and RDF/XML interfaces, and support for a variety of
AI-related applications, such as scheduling, planning and diagnosis.

Status
------

It has been tested in Allegro 9.0, clisp 2.48, ECL 13.5.1, LispWorks 6.1.1
and SBCL 1.1.2 (Win32).

It should run unmodified in any Lisp that implements the metaobject
protocol, and can be used in conjunction with Closer to MOP
(common-lisp.net/project/closer/).

The file compat.lisp may enable it to work (possibly with a little additional
customization) in other Lisps.

Automatically-generated reader methods (i.e., that behave like
slot-value-reduce) work only in SBCL of the above-mentioned Lisps.  Use
Closer to MOP to fill this lacuna.

Changes Since Last Release
--------------------------

(3.3.1)

Performance improvements to ATMS and class consumer (i.e., rule) invokation

Class consumer parallelism extended to embrace multiple ATMS nodes (when
initiated via nschedule)

Temporary nodes are deleted and their justifications reused

Integration with Closer to MOP (see above)

ASDF-related changes:

XML (de)serialization has its own system definition

There are parallel variants of each system

(3.3.2)

Bug fixes:

Automatically-generated reader methods didn't work if make-method-lambda
was supplied by Closer to MOP.  Also, checking has been added for writers
and multiple readers (both disallowed)

Serialization of a slot's values was incorrect if it had a count with a non-
zero lower bound

Installation Instructions
-------------------------

Method One: use the .asd files accompanying this file  The 'p' variants of
these files establish a dependency on lparallel (lparallel.org).  (You will
need to force recompilation if you switch variants, unless you're good at
configuring ASDF.)

Method Two: follow the steps below.

First, load the file reasoner.lisp.  Second, evaluate (compile-reasoner);
thereafter it can be loaded with (load-reasoner).  Both functions take an
optional argument; if it is NIL (the default) everything XML-related is
excluded.  Finally, (compile-demos) will compile and load the demos;
(load-demos) can be used subsequently to load them.

Evaluate (in-package :rs-user) to use the demos.

The additional files xmlic.lisp and xmlis.lisp interface to the CLLIB and SAX
(CXML, Allegro) XML parsers, respectively.  reasoner-cxml.asd may be used to
load the latter and CXML.

Acknowledgement
---------------

I am indebted to many people (too many to mention individually) whose ideas
have helped shape this work.


Dr William Hounslow
Author/Maintainer
http://sourceforge.net/projects/reasoner/
hounslow@users.sourceforge.net