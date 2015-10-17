(in-package :asdf)
(pushnew :rparallel *features*)
(defsystem "preasoner-demos" :depends-on ("reasoner-demos"))