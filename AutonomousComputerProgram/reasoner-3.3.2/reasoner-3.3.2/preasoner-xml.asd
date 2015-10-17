(in-package :asdf)
(pushnew :rparallel *features*)
(defsystem "preasoner-xml" :depends-on ("reasoner-xml"))