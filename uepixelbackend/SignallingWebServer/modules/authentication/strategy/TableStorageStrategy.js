const bcrypt = require("bcryptjs");
const passport = require("passport");
const LocalStrategy = require("passport-local").Strategy;
const users = require("../db/users");

module.exports = () => {
  passport.use(
    new LocalStrategy((username, password, callback) => {
      // Use findByUsername from users.js to find the user locally
      users.findByUsername(username, (err, user) => {
        if (err) {
          return callback(err);
        }
        if (!user) {
          console.log(`User '${username}' not found`);
          return callback(null, false);
        }
        
        bcrypt.compare(password, user.passwordHash, (err, isValid) => {
          if (err) {
            console.log(`Error comparing password for user '${username}': ${err}`);
            return callback(err);
          }

          if (!isValid) {
            console.log(`Password incorrect for user '${username}'`);
            return callback(null, false);
          }

          console.log(`User '${username}' logged in`);
          return callback(null, user);
        });
      });
    })
  );
};
