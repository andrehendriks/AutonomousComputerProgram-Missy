;;; Copyright (C) 2007-2009, 2011-14 by William Hounslow
;;; This is free software, covered by the GNU GPL (v2)
;;; See http://www.gnu.org/copyleft/gpl.html


(in-package :cl-user)

#+(or abcl allegro clisp clozure cmu ecl lispworks mcl sbcl scl)
(pushnew :mop *features*)

;;; Minimal defsystem facility - no dependencies between files.

(defstruct simple-system
  name directory-name specification)

#-(or allegro asdf)
(defmacro defsystem (name directory-name specification)
  `(add-simple-system ',name ,directory-name ',specification))

(let ((system-list nil))

  (defun add-simple-system (name directory-name specification)
    (push (make-simple-system :name name
                              :directory-name directory-name
                              :specification specification)
          system-list))

  (defun operate-on-simple-system (name operation &aux system)
    (flet ((operate-on-file (name directory-name operation &aux output-pathname)
             (setq output-pathname
                   (compile-file-pathname
                    (merge-pathnames (make-pathname :directory
                                                    '(:relative :back "bin")
                                                    :name name)
                                     directory-name)))
             (ecase operation
               (:compile (compile-file (make-pathname :name name
                                                      :type #+ecl "lisp"
                                                            #-ecl nil
                                                   ; Source file has implicit type
                                                   ; LISP (interpreted
                                                   ; implementation-dependently).
                                                      :defaults directory-name)
                                       :output-file output-pathname)
                         (load output-pathname))
               (:load (load output-pathname)))))
      (setq system (find name system-list :key #'simple-system-name))
      (when system
        (dolist (filename (simple-system-specification system))
          (operate-on-file filename
                           (simple-system-directory-name system)
                           operation)))
      system))
) ;end let system-list

(defun compile-reasoner (&optional all)
  (operate-on-simple-system 'reasoner :compile)
  (when all
    (operate-on-simple-system 'reasoner-xml :compile)))

(defun load-reasoner (&optional all)
  (operate-on-simple-system 'reasoner :load)
  (when all
    (operate-on-simple-system 'reasoner-xml :load)))

;;; (defsystem reasoner *load-truename*
;;;   ("rparallel"
;;;    "streams"
;;;    "atms"
;;;    "backtrack"
;;;    "rsexport"
;;;    "slotval"
;;;    "extclass"
;;;    "compat"
;;;    "composite"
;;;    "range"
;;;    "prop"
;;;    "consumer"
;;;    "wff"
;;;    "defrule"
;;;    "genrule"
;;;    "rsuser"))

(add-simple-system 'reasoner
                   *load-truename*
                   '("rparallel"
                     "streams"
                     "atms"
                     "backtrack"
                     "rsexport"
                     "slotval"
                     "extclass"
#-mop                "compat"
                     "composite"
                     "range"
                     "prop"
                     "consumer"
                     "wff"
                     "defrule"
                     "genrule"
                     "rsuser"))

(add-simple-system 'reasoner-xml
                   *load-truename*
                   '("xmlnames"
                     "deserial"
                     "serial"
                     "datatype"
                     "triple"))

(defun compile-demos nil (operate-on-simple-system 'reasoner-demos :compile))

(defun load-demos nil (operate-on-simple-system 'reasoner-demos :load))

(add-simple-system 'reasoner-demos
                   (merge-pathnames (make-pathname :directory '(:relative :back "demos"))
                                    *load-truename*)
                   '("plan"
                     "combin"
                     "pref"
                     "miss"
                     "blocks"
                     "queens"
                     "su"
                     "mult"
                     "career"
                     "boris"))