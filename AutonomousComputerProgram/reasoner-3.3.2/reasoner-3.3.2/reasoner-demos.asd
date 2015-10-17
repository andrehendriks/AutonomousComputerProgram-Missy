(in-package :asdf)

(defsystem "reasoner-demos"
  :depends-on ("reasoner")
  :pathname "demos"
  :components
  ((:file "plan")
   (:file "combin")
   (:file "pref")
   (:file "miss" :depends-on ("plan"))
   (:file "blocks" :depends-on ("plan"))
   (:file "queens" :depends-on ("combin"))
   (:file "su" :depends-on ("combin"))
   (:file "mult")
   (:file "career" :depends-on ("pref"))
   (:file "boris" :depends-on ("pref"))))