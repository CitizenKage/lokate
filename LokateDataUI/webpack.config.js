"use strict";

module.exports = {
    entry: "./index.js",
    output: {
        filename: "bundle.js"
    },
    module: {
        loaders: [
            {
                test: /\.js$/,
                loader: "babel-loader",
                exclude: /node_modules/,
                query: {
                    presets: ["es2015", "react"]
                }
            }
        ]
    },
    externals: {
        'Config': JSON.stringify(process.env.ENV === 'production' ? {
            serverUrl: "http://myserver.com"
        } : {
                serverUrl: "http://localhost:55616"
            })
    }
};
