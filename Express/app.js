const express = require('express');
const Person = require('./person');
const app = express();
const port = 7707;
 
 
app.use(express.static(__dirname));
 
 
app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname, 'index.html'));
});
 
 
app.get('/random-person', (req, res) => {
  const person = new Person(
    Honza,
    Stloukal,
    5
  );
  res.json(person);
});
 
 
app.listen(port, () => {
  console.log(`Server listening on port ${port}`);
});