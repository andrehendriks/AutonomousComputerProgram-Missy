(in-package :asdf)

#+(or abcl allegro clisp clozure cmu ecl lispworks mcl sbcl scl)
(pushnew :mop *features*)

(defsystem "reasoner"
  :depends-on (#+rparallel "lparallel")
  :pathname "src"
  :serial t
  :components
  ((:file "rparallel")
   (:file "streams")
   (:module "atms"
    :pathname ""
    :serial t
    :components ((:file "atms")
                 (:file "backtrack")))
   (:file "rsexport")
   (:module "reasoner-object"
    :pathname ""
    :serial t
    :components ((:file "slotval")
                 (:file "extclass")
#-mop            (:file "compat")
                 (:file "composite")
                 (:file "range")))
   (:module "reasoner-rule"
    :pathname ""
    :serial t
    :components ((:file "prop")
                 (:file "consumer")
                 (:file "wff")
                 (:file "defrule")
                 (:file "genrule")))
   (:file "rsuser")))