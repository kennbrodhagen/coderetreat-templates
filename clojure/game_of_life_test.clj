(ns game-of-life.test (:use clojure.test))
(load-file "game_of_life.clj")

(deftest fails-miserably
  (is (true? false)))

(run-tests)