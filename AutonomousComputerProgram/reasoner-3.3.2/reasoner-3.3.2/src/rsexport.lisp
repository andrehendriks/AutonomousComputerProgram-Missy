;;; Copyright (C) 2007, 2009, 2011-14 by William Hounslow
;;; This is free software, covered by the GNU GPL (v2)
;;; See http://www.gnu.org/copyleft/gpl.html


(defpackage :reasoner
  (:nicknames :rs)
  (:use :rparallel :streams :atms #-closer-mop :cl #+closer-mop :c2cl)
#-(or closer-mop abcl clozure cmu mcl sbcl)
  (:use :clos)
#+(and (not closer-mop) abcl)
  (:use :mop)
#+(and (not closer-mop) (or clozure mcl))
  (:use :ccl)
#+(and (not closer-mop) cmu)
  (:use :clos-mop)
#+(and (not closer-mop) sbcl)
  (:use :sb-pcl)
  (:shadow #:variable)
#+ecl
  (:shadow #:class-slots)
#+lispworks
  (:shadow #:find-slot-definition)
#+(and (not closer-mop) lispworks)
  (:shadow #:make-method-lambda #:slot-value-using-class))

(in-package reasoner)
(eval-when (:execute :compile-toplevel :load-toplevel)
#+allegro
  (progn
    (push (string :reasoner)
          (excl:package-implementation-packages (find-package :cl)))
    (push (string :reasoner)
          (excl:package-implementation-packages (find-package :clos))))

(export '(make-assumption uniquify-environment
          in-p truep contradictoryp subsumesp
          assumption environment
          head tail
          schedule nschedule backtrack solutions
          order-control-disjunction added-assumption add-contradiction conflictp
          describe-data map-slots classify notice-slot-values
          assume-slot-value assume-slot-values reinitialize-atms
          *atms* *empty-environment* contradictory-value contradictory-value-p
          extended-class extended-object
          instance-name instance-assumption find-instance
          slot-value-typep add-slot-value slot-value-reduce slot-values
          add-slot-value-using-class slot-definition-missing
          validate-combination fetch-node fetch-assumption
          elements remove-slot-value remove-node
          numeric-range symbolic-range big -big true-or-false true false
          zero-or-one zero-or-more exactly-one one-or-more defrange
          numeric-rangep range-max range-min
          ensure-named-instance ensure-named-instance-using-class
          source-form rule-compile uncompile
          defconstraint defrule -> <-> lisp is in includes
          aggregate-min aggregate-max aggregate-sum
          *trace-rule-failure* *rule-trace-output*
          rules-using rules-affecting slot-affected slots-used
          attribute-reference-class attribute-name
          compound-object assembly part component parts
          ))
)

;;; Hide some MOP implementation idiosyncrasies.

#+ecl
(defmethod class-slots ((class t))
  (clos:class-slots class))

#+(and (not closer-mop) lispworks)
(defmacro slot-value-using-class (class object slot)
  `(clos:slot-value-using-class ,class ,object (slot-definition-name ,slot)))