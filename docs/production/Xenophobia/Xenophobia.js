if (typeof kotlin === 'undefined') {
  throw new Error("Error loading module 'Xenophobia'. Its dependency 'kotlin' was not found. Please, check whether 'kotlin' is loaded prior to 'Xenophobia'.");
}
var Xenophobia = function (_, Kotlin) {
  'use strict';
  var throwCCE = Kotlin.throwCCE;
  var Unit = Kotlin.kotlin.Unit;
  var canvas;
  var renderer;
  function resizeProcedure() {
    canvas.width = window.innerWidth;
    canvas.height = window.innerHeight;
  }
  function main$lambda(it) {
    resizeProcedure();
    return Unit;
  }
  function main() {
    window.onresize = main$lambda;
  }
  Object.defineProperty(_, 'canvas', {
    get: function () {
      return canvas;
    }
  });
  Object.defineProperty(_, 'renderer', {
    get: function () {
      return renderer;
    }
  });
  _.resizeProcedure = resizeProcedure;
  _.main = main;
  var tmp$, tmp$_0;
  canvas = Kotlin.isType(tmp$ = document.getElementById('canvas'), HTMLCanvasElement) ? tmp$ : throwCCE();
  renderer = Kotlin.isType(tmp$_0 = canvas.getContext('2d'), CanvasRenderingContext2D) ? tmp$_0 : throwCCE();
  main();
  Kotlin.defineModule('Xenophobia', _);
  return _;
}(typeof Xenophobia === 'undefined' ? {} : Xenophobia, kotlin);
