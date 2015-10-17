(in-package :asdf)
(pushnew :rparallel *features*)
(defsystem "preasoner" :depends-on ("reasoner"))