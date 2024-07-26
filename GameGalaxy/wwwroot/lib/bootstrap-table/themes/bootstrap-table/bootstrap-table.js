(function (global, factory) {
  typeof exports === 'object' && typeof module !== 'undefined' ? factory(require('core-js/modules/es.array.find.js'), require('core-js/modules/es.array.includes.js'), require('core-js/modules/es.object.to-string.js'), require('core-js/modules/es.string.includes.js'), require('jquery')) :
  typeof define === 'function' && define.amd ? define(['core-js/modules/es.array.find.js', 'core-js/modules/es.array.includes.js', 'core-js/modules/es.object.to-string.js', 'core-js/modules/es.string.includes.js', 'jquery'], factory) :
  (global = typeof globalThis !== 'undefined' ? globalThis : global || self, factory(null, null, null, null, global.jQuery));
})(this, (function (es_array_find_js, es_array_includes_js, es_object_toString_js, es_string_includes_js, $) { 'use strict';

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

  /**
   * @author Dustin Utecht
   * https://github.com/wenzhixin/bootstrap-table/
   */

  $.fn.bootstrapTable.theme = 'bootstrap-table';
  $.BootstrapTable = /*#__PURE__*/function (_$$BootstrapTable) {
    function _class() {
      _classCallCheck(this, _class);
      return _callSuper(this, _class, arguments);
    }
    _inherits(_class, _$$BootstrapTable);
    return _createClass(_class, [{
      key: "init",
      value: function init() {
        _get(_getPrototypeOf(_class.prototype), "init", this).call(this);
        this.constants.classes.dropup = 'dropdown-menu-up';
        $('.modal').on('click', '[data-close]', function (e) {
          $(e.delegateTarget).removeClass('show');
        });
      }
    }, {
      key: "initConstants",
      value: function initConstants() {
        _get(_getPrototypeOf(_class.prototype), "initConstants", this).call(this);
        this.constants.html.inputGroup = '<div class="input-group">%s%s</div>';
      }
    }, {
      key: "initToolbar",
      value: function initToolbar() {
        _get(_getPrototypeOf(_class.prototype), "initToolbar", this).call(this);
        this.handleToolbar();
      }
    }, {
      key: "handleToolbar",
      value: function handleToolbar() {
        if (this.$toolbar.find('.dropdown-toggle').length) {
          this._initDropdown();
        }
      }
    }, {
      key: "initPagination",
      value: function initPagination() {
        _get(_getPrototypeOf(_class.prototype), "initPagination", this).call(this);
        if (this.options.pagination && this.paginationParts.includes('pageSize')) {
          this._initDropdown();
        }
      }
    }, {
      key: "_initDropdown",
      value: function _initDropdown() {
        var $dropdownToggles = $('.dropdown-toggle');
        $dropdownToggles.off('click').on('click', function (e) {
          var $target = $(e.currentTarget);
          if ($target.parents('.dropdown-toggle').length > 0) {
            $target = $target.parents('.dropdown-toggle');
          }
          $target.next('.dropdown-menu').toggleClass('open');
        });
        $(window).off('click').on('click', function (e) {
          var $dropdownToggles = $('.dropdown-toggle');
          if ($(e.target).parents('.dropdown-toggle, .dropdown-menu').length === 0 && !$(e.target).hasClass('dropdown-toggle')) {
            $dropdownToggles.next('.dropdown-menu').removeClass('open');
          }
        });
      }
    }]);
  }($.BootstrapTable);

}));
