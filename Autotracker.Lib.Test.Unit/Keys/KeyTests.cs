using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autotracker.Lib;
using System.Collections.Generic;
using Autotracker.Lib.Interfaces;
using Autotracker.Lib.Interfaces.Fakes;

namespace Autotracker.Lib.Test.Unit
{
    [TestClass]
    public class KeyTests
    {
        const int _baseNote = 0;
        const int _keyChangeBaseNote = 20;
        const int _keyOctaveChangeBaseNote = _baseNote + Definitions._notesInOctave;

        MajorKey _majorKey;
        MinorKey _minorKey;
        MajorPentatonicKey _majorPentatonicKey;
        MinorPentatonicKey _minorPentatonicKey;
        MajorKey _majorKeyAlt;
        MajorKey _majorKeyHigherOctave;
        
        [TestInitialize]
        public void Setup()
        {
            _majorKey = new MajorKey { BaseNote = _baseNote };
            _minorKey = new MinorKey { BaseNote = _baseNote };
            _majorPentatonicKey = new MajorPentatonicKey { BaseNote = _baseNote };
            _minorPentatonicKey = new MinorPentatonicKey { BaseNote = _baseNote };
            
            // Check a random key change
            _majorKeyAlt = new MajorKey { BaseNote = _keyChangeBaseNote };

            _majorKeyHigherOctave = new MajorKey { BaseNote = _keyOctaveChangeBaseNote };
        }

        [TestMethod]
        public void MajorKeyOctaveNoteCheckSuccess()
        {
            Assert.IsTrue(_majorKey.HasNote(0));
            Assert.IsFalse(_majorKey.HasNote(1));
            Assert.IsTrue(_majorKey.HasNote(2));
            Assert.IsFalse(_majorKey.HasNote(3));
            Assert.IsTrue(_majorKey.HasNote(4));
            Assert.IsTrue(_majorKey.HasNote(5));
            Assert.IsFalse(_majorKey.HasNote(6));
            Assert.IsTrue(_majorKey.HasNote(7));
            Assert.IsFalse(_majorKey.HasNote(8));
            Assert.IsTrue(_majorKey.HasNote(9));
            Assert.IsFalse(_majorKey.HasNote(10));
            Assert.IsTrue(_majorKey.HasNote(11));
        }

        [TestMethod]
        public void MinorKeyOctaveNoteCheckSuccess()
        {
            Assert.IsTrue(_minorKey.HasNote(0));
            Assert.IsFalse(_minorKey.HasNote(1));
            Assert.IsTrue(_minorKey.HasNote(2));
            Assert.IsTrue(_minorKey.HasNote(3));
            Assert.IsFalse(_minorKey.HasNote(4));
            Assert.IsTrue(_minorKey.HasNote(5));
            Assert.IsFalse(_minorKey.HasNote(6));
            Assert.IsTrue(_minorKey.HasNote(7));
            Assert.IsTrue(_minorKey.HasNote(8));
            Assert.IsFalse(_minorKey.HasNote(9));
            Assert.IsTrue(_minorKey.HasNote(10));
            Assert.IsFalse(_minorKey.HasNote(11));
        }

        [TestMethod]
        public void MajorPentatonicKeyOctaveNoteCheckSuccess()
        {
            Assert.IsTrue(_majorPentatonicKey.HasNote(0));
            Assert.IsFalse(_majorPentatonicKey.HasNote(1));
            Assert.IsTrue(_majorPentatonicKey.HasNote(2));
            Assert.IsFalse(_majorPentatonicKey.HasNote(3));
            Assert.IsTrue(_majorPentatonicKey.HasNote(4));
            Assert.IsFalse(_majorPentatonicKey.HasNote(5));
            Assert.IsFalse(_majorPentatonicKey.HasNote(6));
            Assert.IsTrue(_majorPentatonicKey.HasNote(7));
            Assert.IsFalse(_majorPentatonicKey.HasNote(8));
            Assert.IsTrue(_majorPentatonicKey.HasNote(9));
            Assert.IsFalse(_majorPentatonicKey.HasNote(10));
            Assert.IsFalse(_majorPentatonicKey.HasNote(11));
        }

        [TestMethod]
        public void MinorPentatonicKeyOctaveNoteCheckSuccess()
        {
            Assert.IsTrue(_minorPentatonicKey.HasNote(0));
            Assert.IsFalse(_minorPentatonicKey.HasNote(1));
            Assert.IsFalse(_minorPentatonicKey.HasNote(2));
            Assert.IsTrue(_minorPentatonicKey.HasNote(3));
            Assert.IsFalse(_minorPentatonicKey.HasNote(4));
            Assert.IsTrue(_minorPentatonicKey.HasNote(5));
            Assert.IsFalse(_minorPentatonicKey.HasNote(6));
            Assert.IsTrue(_minorPentatonicKey.HasNote(7));
            Assert.IsFalse(_minorPentatonicKey.HasNote(8));
            Assert.IsFalse(_minorPentatonicKey.HasNote(9));
            Assert.IsTrue(_minorPentatonicKey.HasNote(10));
            Assert.IsFalse(_minorPentatonicKey.HasNote(11));
        }

        [TestMethod]
        public void MajorKeyOctaveNoteCheckKeyChangeSuccess()
        {
            Assert.IsTrue(_majorKeyAlt.HasNote(_keyChangeBaseNote));
            Assert.IsFalse(_majorKeyAlt.HasNote(_keyChangeBaseNote + 1));
            Assert.IsTrue(_majorKeyAlt.HasNote(_keyChangeBaseNote + 2));
            Assert.IsFalse(_majorKeyAlt.HasNote(_keyChangeBaseNote + 3));
            Assert.IsTrue(_majorKeyAlt.HasNote(_keyChangeBaseNote + 4));
            Assert.IsTrue(_majorKeyAlt.HasNote(_keyChangeBaseNote + 5));
            Assert.IsFalse(_majorKeyAlt.HasNote(_keyChangeBaseNote + 6));
            Assert.IsTrue(_majorKeyAlt.HasNote(_keyChangeBaseNote + 7));
            Assert.IsFalse(_majorKeyAlt.HasNote(_keyChangeBaseNote + 8));
            Assert.IsTrue(_majorKeyAlt.HasNote(_keyChangeBaseNote + 9));
            Assert.IsFalse(_majorKeyAlt.HasNote(_keyChangeBaseNote + 10));
            Assert.IsTrue(_majorKeyAlt.HasNote(_keyChangeBaseNote + 11));
        }

        [TestMethod]
        public void MajorKeyOctaveNoteCheckHigherOctaveSuccess()
        {
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 1));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 2));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 3));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 4));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 5));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 6));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 7));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 8));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 9));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 10));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 11));
        }

        [TestMethod]
        public void MajorKeyOctaveNoteCheckHigherOctaveExtendedSuccess()
        {
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 12));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 13));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 14));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 15));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 16));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 17));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 18));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 19));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 20));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 21));
            Assert.IsFalse(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 22));
            Assert.IsTrue(_majorKeyHigherOctave.HasNote(_keyOctaveChangeBaseNote + 23));
        }
    }
}
