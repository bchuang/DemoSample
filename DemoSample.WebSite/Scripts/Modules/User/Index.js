var $ApiURL = 'http://localhost/demo_api/api/User';
var vue = new Vue({
    el: '#app', //網頁最外層的 id，所有 vue 操控的部分，皆要寫在裡面
    data: {
        searchKey: "",
        users:
      [
        {
            id: 'Id讀取中',
            name: '名稱讀取中',
            acct: '帳號讀取中'
        }
      ]
        //網頁用到的資料都放在這
    },
    created: function () {
        // 網頁載入完成，先執行的 function 內容寫在這(像 jQ 的 .ready())
        this.get_user();
    },
    methods: {
        //各種要用的 function 寫在這
        get_user: function () {
            axios.get($ApiURL).then(function (response) {
                vue.users = response.data.data;
            }, function (error) {
                console.log(error.statusText);
            });
        },
        edit_user: function (acct) {
            location.href = "/demo/user/update?acct=" + acct;
        },
        delete_user: function (acct) {
            axios.delete($ApiURL, { params: { acct: acct } }).then(function (response) {
                vue.get_user();
            }, function (error) {
                console.log(error.statusText);
            });
        },
    },
    computed: {
        //計算屬性，好用，但此範例沒用到 XDD
    }
});

function finduser(userId) {
    return vue.users[finduserKey(userId)];
};

function finduserKey(userId) {
    for (var key = 0; key < vue.users.length; key++) {
        if (vue.users[key].id == userId) {
            return key;
        }
    }
};

var List = Vue.extend({
    data: function () {
        return { users: vue.users, searchKey: '' };
    }
});