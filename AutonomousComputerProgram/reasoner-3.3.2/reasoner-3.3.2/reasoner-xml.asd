(in-package :asdf)

(defsystem "reasoner-xml"
  :depends-on ("reasoner")
  :pathname "src"
  :serial t
  :components ((:file "xmlnames")
               (:file "deserial")
               (:file "serial")
               (:file "datatype")
               (:file "triple")))