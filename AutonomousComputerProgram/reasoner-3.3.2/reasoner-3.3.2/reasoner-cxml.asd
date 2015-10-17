(in-package :asdf)

(defsystem "reasoner-cxml"
  :depends-on ("reasoner-xml" "cxml")
  :pathname "src"
  :components ((:file "xmlis")))