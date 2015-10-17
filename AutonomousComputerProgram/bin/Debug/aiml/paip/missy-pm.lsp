;;;; -*- Mode: Lisp; Syntax: Common-Lisp -*-
;;;; Code from Paradigms of AI Programming
;;;; Copyright (c) 1991 Peter Norvig

;;;; File missy-pm.lisp: Updated version of eliza in section 6.3

(requires "patmatch" "missy")

(defun missy ()
  "Respond to user input using pattern matching rules."
  (loop
    (print 'missy>)
    (print (flatten (use-missy-rules (read))))))

(defun use-missy-rules (input)
  "Find some rule with which to transform the input."
  (rule-based-translator input *missy-rules*   
    :action #'(lambda (bindings responses)
                (sublis (switch-viewpoint bindings)
                        (random-elt responses)))))

