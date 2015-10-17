(in-package :asdf)
(pushnew :rparallel *features*)
(defsystem "preasoner-cxml" :depends-on ("reasoner-cxml"))