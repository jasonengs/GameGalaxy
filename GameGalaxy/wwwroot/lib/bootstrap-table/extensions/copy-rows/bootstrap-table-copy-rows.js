(function (global, factory) {
  typeof exports === 'object' && typeof module !== 'undefined' ? factory(require('core-js/modules/es.array.concat.js'), require('core-js/modules/es.array.find.js'), require('core-js/modules/es.array.join.js'), require('core-js/modules/es.object.assign.js'), require('core-js/modules/es.object.to-string.js'), require('core-js/modules/web.dom-collections.for-each.js'), require('jquery')) :
  typeof define === 'function' && define.amd ? define(['core-js/modules/es.array.concat.js', 'core-js/modules/es.array.find.js', 'core-js/modules/es.array.join.js', 'core-js/modules/es.object.assign.js', 'core-js/modules/es.object.to-string.js', 'core-js/modules/web.dom-collections.for-each.js', 'jquery'], factory) :
  (global = typeof globalThis !== 'undefined' ? globalThis : global || self, factory(null, null, null, null, null, null, global.jQuery));
})(this, (function (es_array_concat_js, es_array_find_js, es_array_join_js, es_object_assign_js, es_object_toString_js, web_domCollections_forEach_js, $) { 'use strict';

  function _arrayLikeToArray(r, a) {
    (null == a || a > r.length) && (a = r.length);
    for (var e = 0, n = Array(a); e < a; e++) n[e] = r[e];
    return n;
  }
  function _assertThisInitialized(e) {
    if (void 0 === e) throw new ReferenceError("this hasn't been initialised - super() hasn't been called");
    return e;
  }
  function _callSuper(t, o, e) {
    return o = _getPrototypeOf(o), _possibleConstructorReturn(t, _isNativeReflectConstruct() ? Reflect.construct(o, e || [], _getPrototypeOf(t).constructor) : o.apply(t, e));
  }
  function _classCallCheck(a, n) {
    if (!(a instanceof n)) throw new TypeError("Cannot call a class as a function");
  }
  function _defineProperties(e, r) {
    for (var t = 0; t < r.length; t++) {
      var o = r[t];
      o.enumerable = o.enumerable || !1, o.configurable = !0, "value" in o && (o.writable = !0), Object.defineProperty(e, _toPropertyKey(o.key), o);
    }
  }
  function _createClass(e, r, t) {
    return r && _defineProperties(e.prototype, r), Object.defineProperty(e, "prototype", {
      writable: !1
    }), e;
  }
  function _createForOfIteratorHelper(r, e) {
    var t = "undefined" != typeof Symbol && r[Symbol.iterator] || r["@@iterator"];
    if (!t) {
      if (Array.isArray(r) || (t = _unsupportedIterableToArray(r)) || e  ) {
        t && (r = t);
        var n = 0,
          F = function () {};
        return {
          s: F,
          n: function () {
            return n >= r.length ? {
              done: !0
            } : {
              done: !1,
              value: r[n++]
            };
          },
          e: function (r) {
            throw r;
          },
          f: F
        };
      }
      throw new TypeError("Invalid attempt to iterate non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.");
    }
    var o,
      a = !0,
      u = !1;
    return {
      s: function () {
        t = t.call(r);
      },
      n: function () {
        var r = t.next();
        return a = r.done, r;
      },
      e: function (r) {
        u = !0, o = r;
      },
      f: function () {
        try {
          a || null == t.return || t.return();
        } finally {
          if (u) throw o;
        }
      }
    };
  }
  function _get() {
    return _get = "undefined" != typeof Reflect && Reflect.get ? Reflect.get.bind() : function (e, t, r) {
      var p = _superPropBase(e, t);
      if (p) {
        var n = Object.getOwnPropertyDescriptor(p, t);
        return n.get ? n.get.call(arguments.length < 3 ? e : r) : n.value;
      }
    }, _get.apply(null, arguments);
  }
  function _getPrototypeOf(t) {
    return _getPrototypeOf = Object.setPrototypeOf ? Object.getPrototypeOf.bind() : function (t) {
      return t.__proto__ || Object.getPrototypeOf(t);
    }, _getPrototypeOf(t);
  }
  function _inherits(t, e) {
    if ("function" != typeof e && null !== e) throw new TypeError("Super expression must either be null or a function");
    t.prototype = Object.create(e && e.prototype, {
      constructor: {
        value: t,
        writable: !0,
        configurable: !0
      }
    }), Object.defineProperty(t, "prototype", {
      writable: !1
    }), e && _setPrototypeOf(t, e);
  }
  function _isNativeReflectConstruct() {
    try {
      var t = !Boolean.prototype.valueOf.call(Reflect.construct(Boolean, [], function () {}));
    } catch (t) {}
    return (_isNativeReflectConstruct = function () {
      return !!t;
    })();
  }
  function _possibleConstructorReturn(t, e) {
    if (e && ("object" == typeof e || "function" == typeof e)) return e;
    if (void 0 !== e) throw new TypeError("Derived constructors may only return object or undefined");
    return _assertThisInitialized(t);
  }
  function _setPrototypeOf(t, e) {
    return _setPrototypeOf = Object.setPrototypeOf ? Object.setPrototypeOf.bind() : function (t, e) {
      return t.__proto__ = e, t;
    }, _setPrototypeOf(t, e);
  }
  function _superPropBase(t, o) {
    for (; !{}.hasOwnProperty.call(t, o) && null !== (t = _getPrototypeOf(t)););
    return t;
  }
  function _toPrimitive(t, r) {
    if ("object" != typeof t || !t) return t;
    var e = t[Symbol.toPrimitive];
    if (void 0 !== e) {
      var i = e.call(t, r );
      if ("object" != typeof i) return i;
      throw new TypeError("@@toPrimitive must return a primitive value.");
    }
    return (String )(t);
  }
  function _toPropertyKey(t) {
    var i = _toPrimitive(t, "string");
    return "symbol" == typeof i ? i : i + "";
  }
  function _unsupportedIterableToArray(r, a) {
    if (r) {
      if ("string" == typeof r) return _arrayLikeToArray(r, a);
      var t = {}.toString.call(r).slice(8, -1);
      return "Object" === t && r.constructor && (t = r.constructor.name), "Map" === t || "Set" === t ? Array.from(r) : "Arguments" === t || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(t) ? _arrayLikeToArray(r, a) : void 0;
    }
  }

  /**
   * @author Homer Glascock <HopGlascock@gmail.com>
   * @update zhixin wen <wenzhixin2010@gmail.com>
   */

  var Utils = $.fn.bootstrapTable.utils;
  Object.assign($.fn.bootstrapTable.locales, {
    formatCopyRows: function formatCopyRows() {
      return 'Copy Rows';
    }
  });
  Object.assign($.fn.bootstrapTable.defaults, $.fn.bootstrapTable.locales);
  Object.assign($.fn.bootstrapTable.defaults.icons, {
    copy: {
      bootstrap3: 'glyphicon-copy icon-pencil',
      bootstrap5: 'bi-clipboard',
      materialize: 'content_copy',
      'bootstrap-table': 'icon-copy'
    }[$.fn.bootstrapTable.theme] || 'fa-copy'
  });
  var copyText = function copyText(text) {
    var textField = document.createElement('textarea');
    $(textField).html(text);
    document.body.appendChild(textField);
    textField.select();
    try {
      document.execCommand('copy');
    } catch (e) {
      console.warn('Oops, unable to copy');
    }
    $(textField).remove();
  };
  Object.assign($.fn.bootstrapTable.defaults, {
    showCopyRows: false,
    copyWithHidden: false,
    copyDelimiter: ', ',
    copyNewline: '\n',
    copyRowsHandler: function copyRowsHandler(text) {
      return text;
    }
  });
  Object.assign($.fn.bootstrapTable.columnDefaults, {
    ignoreCopy: false,
    rawCopy: false
  });
  $.fn.bootstrapTable.methods.push('copyColumnsToClipboard');
  $.BootstrapTable = /*#__PURE__*/function (_$$BootstrapTable) {
    function _class() {
      _classCallCheck(this, _class);
      return _callSuper(this, _class, arguments);
    }
    _inherits(_class, _$$BootstrapTable);
    return _createClass(_class, [{
      key: "initToolbar",
      value: function initToolbar() {
        var _get2;
        if (this.options.showCopyRows && this.header.stateField) {
          this.buttons = Object.assign(this.buttons, {
            copyRows: {
              text: this.options.formatCopyRows(),
              icon: this.options.icons.copy,
              event: this.copyColumnsToClipboard,
              attributes: {
                'aria-label': this.options.formatCopyRows(),
                title: this.options.formatCopyRows()
              }
            }
          });
        }
        for (var _len = arguments.length, args = new Array(_len), _key = 0; _key < _len; _key++) {
          args[_key] = arguments[_key];
        }
        (_get2 = _get(_getPrototypeOf(_class.prototype), "initToolbar", this)).call.apply(_get2, [this].concat(args));
        this.$copyButton = this.$toolbar.find('>.columns [name="copyRows"]');
        if (this.options.showCopyRows && this.header.stateField) {
          this.updateCopyButton();
        }
      }
    }, {
      key: "copyColumnsToClipboard",
      value: function copyColumnsToClipboard() {
        var _this = this;
        var rows = [];
        var _iterator = _createForOfIteratorHelper(this.getSelections()),
          _step;
        try {
          var _loop = function _loop() {
            var row = _step.value;
            var cols = [];
            _this.options.columns[0].forEach(function (column, index) {
              if (column.field !== _this.header.stateField && (!_this.options.copyWithHidden || _this.options.copyWithHidden && column.visible) && !column.ignoreCopy) {
                if (row[column.field] !== null) {
                  var columnValue = column.rawCopy ? row[column.field] : Utils.calculateObjectValue(column, _this.header.formatters[index], [row[column.field], row, index], row[column.field]);
                  cols.push(columnValue);
                }
              }
            });
            rows.push(cols.join(_this.options.copyDelimiter));
          };
          for (_iterator.s(); !(_step = _iterator.n()).done;) {
            _loop();
          }
        } catch (err) {
          _iterator.e(err);
        } finally {
          _iterator.f();
        }
        var text = rows.join(this.options.copyNewline);
        text = Utils.calculateObjectValue(this.options, this.options.copyRowsHandler, [text], text);
        copyText(text);
      }
    }, {
      key: "updateSelected",
      value: function updateSelected() {
        _get(_getPrototypeOf(_class.prototype), "updateSelected", this).call(this);
        this.updateCopyButton();
      }
    }, {
      key: "updateCopyButton",
      value: function updateCopyButton() {
        if (this.options.showCopyRows && this.header.stateField && this.$copyButton) {
          this.$copyButton.prop('disabled', !this.getSelections().length);
        }
      }
    }]);
  }($.BootstrapTable);

}));
