(TeX-add-style-hook
 "srs"
 (lambda ()
   (TeX-add-to-alist 'LaTeX-provided-class-options
                     '(("article" "letterpaper" "12pt")))
   (TeX-add-to-alist 'LaTeX-provided-package-options
                     '(("geometry" "margin=1in" "letterpaper")))
   (TeX-run-style-hooks
    "latex2e"
    "introduction"
    "description"
    "features"
    "external"
    "nonfunction"
    "glossary"
    "models"
    "issues"
    "article"
    "art12"
    "geometry"
    "tabularx"))
 :latex)

